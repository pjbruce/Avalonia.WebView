using ObjCRuntime;

namespace Speech;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum SFSpeechRecognitionTaskState : long
{
	Starting,
	Running,
	Finishing,
	Canceling,
	Completed
}
