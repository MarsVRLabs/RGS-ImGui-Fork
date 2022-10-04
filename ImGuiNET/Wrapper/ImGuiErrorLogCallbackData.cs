using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Text;
using Object = UnityEngine.Object;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiErrorLogCallbackData
    {
        public IntPtr ErrorLogCallback;
        public void* UserData;
        public char* fmt;
    }
    public unsafe partial struct ImGuiErrorLogCallbackDataPtr
    {
        public ImGuiErrorLogCallbackData* NativePtr { get; }
        public ImGuiErrorLogCallbackDataPtr(ImGuiErrorLogCallbackData* nativePtr) => NativePtr = nativePtr;
        public ImGuiErrorLogCallbackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiErrorLogCallbackData*)nativePtr;
        public static implicit operator ImGuiErrorLogCallbackDataPtr(ImGuiErrorLogCallbackData* nativePtr) => new ImGuiErrorLogCallbackDataPtr(nativePtr);
        public static implicit operator ImGuiErrorLogCallbackData* (ImGuiErrorLogCallbackDataPtr wrappedDataPtr) => wrappedDataPtr.NativePtr;
        public static implicit operator ImGuiErrorLogCallbackDataPtr(IntPtr nativePtr) => new ImGuiErrorLogCallbackDataPtr(nativePtr);
        public ref IntPtr ErrorLog => ref Unsafe.AsRef<IntPtr>(&NativePtr->ErrorLogCallback);
        public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
    }
}