using System;
using ObjCRuntime;

namespace Foundation;

[Flags]
[Native]
public enum NSSearchPathDomain : ulong
{
	None = 0uL,
	User = 1uL,
	Local = 2uL,
	Network = 4uL,
	System = 8uL,
	All = 0xFFFFuL
}
