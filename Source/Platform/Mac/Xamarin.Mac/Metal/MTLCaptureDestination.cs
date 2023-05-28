using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Native]
public enum MTLCaptureDestination : long
{
	DeveloperTools = 1L,
	GpuTraceDocument
}
