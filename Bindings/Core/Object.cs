using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;


public class Object : RefCounted
{
    protected Context context_;
    
    List<HandleEventFunction> storage = new List<HandleEventFunction>();

    internal Object(IntPtr nativeInstance, Context context) : base(nativeInstance)
    {
        context_ = context;
    }
    
    protected void SubscribeToEvent(StringHash eventType, HandleEventFunction function)
    {
        storage.Add(function);
        Object_SubscribeToEvent(NativeInstance, eventType, function);
    }
    
    
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void HandleEventFunction(IntPtr variantMapPtr);

    [DllImport(Consts.NativeLibName, CallingConvention = CallingConvention.Cdecl)] 
    private static extern void Object_SubscribeToEvent(IntPtr nativeInstance, StringHash eventType, HandleEventFunction function);
}
