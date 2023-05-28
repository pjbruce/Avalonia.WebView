using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Native]
public enum MTLDepthClipMode : ulong
{
	Clip,
	Clamp
}
