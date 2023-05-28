using ObjCRuntime;

namespace CoreML;

[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Native]
public enum MLImageSizeConstraintType : long
{
	Unspecified = 0L,
	Enumerated = 2L,
	Range = 3L
}
