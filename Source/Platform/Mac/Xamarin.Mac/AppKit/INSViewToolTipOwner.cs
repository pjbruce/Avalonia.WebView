using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Protocol(Name = "NSViewToolTipOwner", WrapperType = typeof(NSViewToolTipOwnerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetStringForToolTip", Selector = "view:stringForToolTip:point:userData:", ReturnType = typeof(string), ParameterType = new Type[]
{
	typeof(NSView),
	typeof(nint),
	typeof(CGPoint),
	typeof(IntPtr)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface INSViewToolTipOwner : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("view:stringForToolTip:point:userData:")]
	[Preserve(Conditional = true)]
	string GetStringForToolTip(NSView view, nint tag, CGPoint point, IntPtr data);
}
