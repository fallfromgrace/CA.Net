using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreAudio.Net.Internal
{
    /// <summary>
    /// 
    /// </summary>
    [ComImport]
    [Guid("870af99c-171d-4f9e-af0d-e63df40c2bc9")]
    public class PolicyConfig : IPolicyConfig
    {
        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 GetMixFormat(
            String a,
            IntPtr b);

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 GetDeviceFormat(
            String a,
            Int32 b,
            IntPtr c);

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 ResetDeviceFormat(
            String a);

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 SetDeviceFormat(
            String a,
            IntPtr b,
            IntPtr c);

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 GetProcessingPeriod(
            String a,
            Int32 b,
            ref Int64 c,
            out Int64 d);

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 SetProcessingPeriod(
            String a,
            ref Int64 b);

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 GetShareMode(
            String a,
            IntPtr b);

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 SetShareMode(
            String a,
            IntPtr b);

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 GetPropertyValue(
            String a,
            IntPtr b,
            IntPtr c);

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 SetPropertyValue(
            String a,
            IntPtr b,
            IntPtr c);

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 SetDefaultEndpoint(
            [In] String deviceId,
            [In] Role role);

        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 SetEndpointVisibility(
            String a,
            Int32 b);
    }
}
