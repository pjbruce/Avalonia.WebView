using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSRunResponse : long
{
	Stopped = -1000L,
	Aborted = -1001L,
	Continues = -1002L
}
