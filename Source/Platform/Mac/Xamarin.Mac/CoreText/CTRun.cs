using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreText;

public class CTRun : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public nint GlyphCount => CTRunGetGlyphCount(handle);

	public CTRunStatus Status => CTRunGetStatus(handle);

	public NSRange StringRange => CTRunGetStringRange(handle);

	public CGAffineTransform TextMatrix => CTRunGetTextMatrix(handle);

	internal CTRun(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	internal CTRun(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException("handle");
		}
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	~CTRun()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern void CTRunDraw(IntPtr h, IntPtr context, NSRange range);

	public void Draw(CGContext context, NSRange range)
	{
		CTRunDraw(handle, context.Handle, range);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern void CTRunGetAdvances(IntPtr h, NSRange range, [In][Out] CGSize[] buffer);

	public CGSize[] GetAdvances(NSRange range, CGSize[] buffer)
	{
		buffer = GetBuffer(range, buffer);
		CTRunGetAdvances(handle, range, buffer);
		return buffer;
	}

	private T[] GetBuffer<T>(NSRange range, T[] buffer)
	{
		nint glyphCount = GlyphCount;
		if (buffer != null && range.Length != 0 && buffer.Length < range.Length)
		{
			throw new ArgumentException("buffer.Length must be >= range.Length.", "buffer");
		}
		if (buffer != null && range.Length == 0 && buffer.Length < glyphCount)
		{
			throw new ArgumentException("buffer.Length must be >= GlyphCount.", "buffer");
		}
		return buffer ?? new T[(long)((range.Length == 0) ? glyphCount : range.Length)];
	}

	public CGSize[] GetAdvances(NSRange range)
	{
		return GetAdvances(range, null);
	}

	public CGSize[] GetAdvances()
	{
		return GetAdvances(new NSRange(0, 0), null);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTRunGetAttributes(IntPtr handle);

	public CTStringAttributes GetAttributes()
	{
		NSDictionary nSDictionary = (NSDictionary)Runtime.GetNSObject(CTRunGetAttributes(handle));
		return (nSDictionary == null) ? null : new CTStringAttributes(nSDictionary);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern nint CTRunGetGlyphCount(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern void CTRunGetGlyphs(IntPtr h, NSRange range, [In][Out] ushort[] buffer);

	public ushort[] GetGlyphs(NSRange range, ushort[] buffer)
	{
		buffer = GetBuffer(range, buffer);
		CTRunGetGlyphs(handle, range, buffer);
		return buffer;
	}

	public ushort[] GetGlyphs(NSRange range)
	{
		return GetGlyphs(range, null);
	}

	public ushort[] GetGlyphs()
	{
		return GetGlyphs(new NSRange(0, 0), null);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CGRect CTRunGetImageBounds(IntPtr h, IntPtr context, NSRange range);

	public CGRect GetImageBounds(CGContext context, NSRange range)
	{
		return CTRunGetImageBounds(handle, context.Handle, range);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern void CTRunGetPositions(IntPtr h, NSRange range, [In][Out] CGPoint[] buffer);

	public CGPoint[] GetPositions(NSRange range, CGPoint[] buffer)
	{
		buffer = GetBuffer(range, buffer);
		CTRunGetPositions(handle, range, buffer);
		return buffer;
	}

	public CGPoint[] GetPositions(NSRange range)
	{
		return GetPositions(range, null);
	}

	public CGPoint[] GetPositions()
	{
		return GetPositions(new NSRange(0, 0), null);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CTRunStatus CTRunGetStatus(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern void CTRunGetStringIndices(IntPtr h, NSRange range, [In][Out] nint[] buffer);

	public nint[] GetStringIndices(NSRange range, nint[] buffer)
	{
		buffer = GetBuffer(range, buffer);
		CTRunGetStringIndices(handle, range, buffer);
		return buffer;
	}

	public nint[] GetStringIndices(NSRange range)
	{
		return GetStringIndices(range, null);
	}

	public nint[] GetStringIndices()
	{
		return GetStringIndices(new NSRange(0, 0), null);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern NSRange CTRunGetStringRange(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CGAffineTransform CTRunGetTextMatrix(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTRunGetTypographicBounds(IntPtr h, NSRange range, out nfloat ascent, out nfloat descent, out nfloat leading);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTRunGetTypographicBounds(IntPtr h, NSRange range, IntPtr ascent, IntPtr descent, IntPtr leading);

	public double GetTypographicBounds(NSRange range, out nfloat ascent, out nfloat descent, out nfloat leading)
	{
		return CTRunGetTypographicBounds(handle, range, out ascent, out descent, out leading);
	}

	public double GetTypographicBounds()
	{
		NSRange nSRange = default(NSRange);
		nSRange.Location = 0;
		nSRange.Length = 0;
		NSRange range = nSRange;
		return CTRunGetTypographicBounds(handle, range, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void CTRunGetBaseAdvancesAndOrigins(IntPtr runRef, NSRange range, CGSize[] advancesBuffer, CGPoint[] originsBuffer);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public void GetBaseAdvancesAndOrigins(NSRange range, out CGSize[] advancesBuffer, out CGPoint[] originsBuffer)
	{
		advancesBuffer = GetBuffer<CGSize>(range, null);
		originsBuffer = GetBuffer<CGPoint>(range, null);
		CTRunGetBaseAdvancesAndOrigins(handle, range, advancesBuffer, originsBuffer);
	}
}
