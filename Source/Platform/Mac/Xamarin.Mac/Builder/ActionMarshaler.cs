﻿using System.Reflection;
using System.Runtime.InteropServices;

namespace Builder;
internal class ActionMarshaler<TAction, TActionProxy> : ICustomMarshaler where TAction : Delegate
{
    private static ActionMarshaler<TAction, TActionProxy> marshaler;

    public void CleanUpManagedData(object ManagedObj)
    {
         
    }

    public void CleanUpNativeData(IntPtr pNativeData)
    {
         
    }

    public int GetNativeDataSize()
    {
        return -1;
    }

    public IntPtr MarshalManagedToNative(object ManagedObj)
    {
       return Marshal.GetFunctionPointerForDelegate(ManagedObj);
    }

    public object MarshalNativeToManaged(IntPtr pNativeData)
    {
        if (pNativeData == IntPtr.Zero)
            return default;

        var proxyType = typeof(TActionProxy);
        var createMethod = proxyType.GetMethod("Create", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[1] { typeof(IntPtr) }, null);
        if (createMethod is null)
            return default;

        return createMethod.Invoke(pNativeData, null);
    }

    public static ICustomMarshaler GetInstance(string cookie)
    {
        if (marshaler == null)
            return marshaler = new ActionMarshaler<TAction, TActionProxy>();

        return marshaler;
    }
}
