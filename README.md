How to use
Add [WebView.Avalonia][nuget] or [BlazorWebView.Avalonia][nuget] nuget package to your avaloniaui shared project:

dotnet add package WebView.Avalonia.Cross
             OR
dotnet add package BlazorWebView.Avalonia.Cross
Add [WebView.Avalonia.Desktop][nuget] nuget package to your avaloniaui desktop project:

dotnet add package WebView.Avalonia.Desktop.Cross
Add [WebView.Avalonia.Android][nuget] nuget package to your avaloniaui Android project:

dotnet add package WebView.Avalonia.Android
Add [WebView.Avalonia.iOS][nuget] nuget package to your avaloniaui iOS project:

dotnet add package WebView.Avalonia.iOS
Edit App.axaml.cs file:

 using AvaloniaWebView;

 OR

 using AvaloniaBlazorWebView;
 ...
  public override void RegisterServices()
  {
     base.RegisterServices();
     
     // if you use only WebView  
     AvaloniaWebViewBuilder.Initialize(default);

     // Or
 
     // if you use BlazorWebView, please setting for blazor 
     AvaloniaBlazorWebViewBuilder.Initialize(default, setting =>
     {
         //this is setting for blazor 
         setting.ComponentType = typeof(AppWeb);
         setting.Selector = "#app";

         //because avalonia support the html css and js for resource ,so you must set the ResourceAssembly 
         setting.IsAvaloniaResource = true;
         setting.ResourceAssembly = typeof(AppWeb).Assembly;
     }, inject =>
     {
         //you can inject the resource in this
         inject.AddSingleton<WeatherForecastService>();
     });
  }
Edit Program file for Desktop:

using Avalonia.WebView.Desktop; <<---add this
...
 public static AppBuilder BuildAvaloniaApp()
    => AppBuilder.Configure<App>()
        .UsePlatformDetect()
        .LogToTrace()
        .UseReactiveUI()
        .UseDesktopWebView();   <<---add this
Edit SplashActivity file for Android:

using Avalonia.WebView.Android; <<---add this
...
protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
{
    return base.CustomizeAppBuilder(builder)
        .UseReactiveUI()
        .UseAndroidWebView();  <<---add this
}
Edit AppDelegate file for iOS:

using Avalonia.WebView.iOS;     <<---add this
...
protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
{
    return builder.UseReactiveUI()
    .UseIosWebView();           <<---add this
}
Description
use Webview2 for Windows (please install Microsoft edge Webview2)

use WKWebView[Appkit] for MacOS (system in)

use Webkit Webview for Linux (if not please install [sudo apt-get libwebkit2gtk-4-37])

use Android.Webkit.WebView for Android (this is in Microsoft-Android [net5.0-Android; net6.0-Android; net8.0-Android])

use WKWebView[UIKit] for iOS (this is in Microsoft-iOS [net5.0-ios; net6.0-ios; net8.0-ios])

Platform	Technologies
Windows	WebView2
MacOS	WKWebView(Appkit)
Linux	Gtk3,WebKitGtk3
Android	Android.Webkit.WebView
iOS	WKWebView(UIKit)
