using System;
using ObjCRuntime;

namespace Foundation;

public static class NSPredicateSupport_NSMutableSet
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterUsingPredicate_ = "filterUsingPredicate:";

	private static readonly IntPtr selFilterUsingPredicate_Handle = Selector.GetHandle("filterUsingPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableSet");

	[Export("filterUsingPredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FilterUsingPredicate(this NSMutableSet This, NSPredicate predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selFilterUsingPredicate_Handle, predicate.Handle);
	}
}
