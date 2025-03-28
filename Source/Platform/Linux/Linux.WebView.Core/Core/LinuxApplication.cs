﻿namespace Linux.WebView.Core;

internal class LinuxApplication : ILinuxApplication
{
    static LinuxApplication()
    {
    }

    public LinuxApplication()
    {
        _dispatcher = new LinuxDispatcher();
    }

    ~LinuxApplication()
    {
        Dispose(disposing: false);
    }


    readonly ILinuxDispatcher _dispatcher;
    Task? _appRunning;
    GDisplay? _defaultDisplay;

    bool _isRunning = false;
    public bool IsRunning
    {
        get => _isRunning;
        protected set => _isRunning = value;
    }

    bool _isDisposed;
    public bool IsDisposed
    {
        get => _isDisposed;
        protected set => _isDisposed = value;
    }

    bool ILinuxApplication.IsRunning => IsRunning;

    ILinuxDispatcher ILinuxApplication.Dispatcher => _dispatcher;

    Task<bool> ILinuxApplication.RunAsync(string? applicationName, string[]? args)
    {
        if (IsRunning)
            return Task.FromResult(true);

        var tcs = new TaskCompletionSource<bool>();
        _appRunning = Task.Factory.StartNew(obj =>
        {
            GtkApi.SetAllowedBackends("x11");
            Environment.SetEnvironmentVariable("WAYLAND_DISPLAY", "/proc/fake-display-to-prevent-wayland-initialization-by-gtk3");
            GApplication.Init();
            _defaultDisplay = GDisplay.Default;

            _dispatcher.Start();
            IsRunning = true;

            tcs.SetResult(true);
            GApplication.Run();

        }, TaskCreationOptions.LongRunning);

        return tcs.Task;
    }

    Task ILinuxApplication.StopAsync()
    {
        if (!IsRunning)
            return Task.CompletedTask;

        _dispatcher.Stop();
        GApplication.Quit();
        _appRunning?.Wait();
        return Task.CompletedTask;
    }

    protected virtual async void Dispose(bool disposing)
    {
        if (!IsDisposed)
        {
            if (disposing)
            {
            }

            await ((ILinuxApplication)this).StopAsync();

            _defaultDisplay?.Dispose();
            _defaultDisplay = null;

            IsDisposed = true;
        }
    }

    void IDisposable.Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    Task<(GWindow, WebKitWebView, IntPtr hostHandle)> ILinuxApplication.CreateWebView()
    {
        if (!_isRunning) throw new InvalidOperationException(nameof(IsRunning));
        return _dispatcher.InvokeAsync(() =>
        {
            var window = new GWindow("WebView.GTK.Window");
            window.DefaultSize = new GSize(1024, 768);

            var webView = new WebKitWebView();
            webView.Realize();
            window.Add(webView);
            window.ShowAll();
            //window.Present();

            return (window, webView, window.X11Handle());
        });
    }


}
