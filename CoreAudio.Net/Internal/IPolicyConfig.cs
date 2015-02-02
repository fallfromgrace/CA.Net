using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CoreAudio.Net.Internal
{
    /// <summary>
    /// The only method that works is SetDefaultEndpoint
    /// </summary>
    [ComImport]
    [SuppressUnmanagedCodeSecurity]
    [Guid("f8679f50-850a-41cf-9c72-430f290290c8")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPolicyConfig
    {
        [PreserveSig]
        Int32 GetMixFormat(
            String a,
            IntPtr b);

        [PreserveSig]
        Int32 GetDeviceFormat(
            String a,
            Int32 b,
            IntPtr c);

        [PreserveSig]
        Int32 ResetDeviceFormat(
            String a);

        [PreserveSig]
        Int32 SetDeviceFormat(
            String a,
            IntPtr b,
            IntPtr c);

        [PreserveSig]
        Int32 GetProcessingPeriod(
            String a,
            Int32 b,
            ref Int64 c,
            out Int64 d);

        [PreserveSig]
        Int32 SetProcessingPeriod(
            String a,
            ref Int64 b);

        [PreserveSig]
        Int32 GetShareMode(
            String a,
            IntPtr b);

        [PreserveSig]
        Int32 SetShareMode(
            String a,
            IntPtr b);

        [PreserveSig]
        Int32 GetPropertyValue(
            String a,
            IntPtr b,
            IntPtr c);

        [PreserveSig]
        Int32 SetPropertyValue(
            String a,
            IntPtr b,
            IntPtr c);

        [PreserveSig]
        Int32 SetDefaultEndpoint(
            [In] String deviceId,
            [In] Role role);

        [PreserveSig]
        Int32 SetEndpointVisibility(
            String a,
            Int32 b);
    }
}
