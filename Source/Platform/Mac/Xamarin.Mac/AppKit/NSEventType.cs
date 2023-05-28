using ObjCRuntime;

namespace AppKit;

[Native]
public enum NSEventType : ulong
{
	LeftMouseDown = 1uL,
	LeftMouseUp = 2uL,
	RightMouseDown = 3uL,
	RightMouseUp = 4uL,
	MouseMoved = 5uL,
	LeftMouseDragged = 6uL,
	RightMouseDragged = 7uL,
	MouseEntered = 8uL,
	MouseExited = 9uL,
	KeyDown = 10uL,
	KeyUp = 11uL,
	FlagsChanged = 12uL,
	AppKitDefined = 13uL,
	SystemDefined = 14uL,
	ApplicationDefined = 15uL,
	Periodic = 16uL,
	CursorUpdate = 17uL,
	ScrollWheel = 22uL,
	TabletPoint = 23uL,
	TabletProximity = 24uL,
	OtherMouseDown = 25uL,
	OtherMouseUp = 26uL,
	OtherMouseDragged = 27uL,
	Gesture = 29uL,
	Magnify = 30uL,
	Swipe = 31uL,
	Rotate = 18uL,
	BeginGesture = 19uL,
	EndGesture = 20uL,
	SmartMagnify = 32uL,
	QuickLook = 33uL,
	Pressure = 34uL,
	DirectTouch = 37uL
}
