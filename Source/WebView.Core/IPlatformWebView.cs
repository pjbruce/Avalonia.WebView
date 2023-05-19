﻿namespace WebViewCore;

public interface IPlatformWebView : IWebViewControl, IDisposable, IAsyncDisposable
{
    Task<bool> Initialize(IVirtualWebViewProvider? virtualProvider);
    bool IsInitialized { get; }

    object? PlatformViewContext { get; }
}
