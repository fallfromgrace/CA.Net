using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CoreAudio.Net
{
    /// <summary>
    /// IMMNotificationClient
    /// </summary>
    [ComImport]
    [SuppressUnmanagedCodeSecurity]
    [Guid("7991EEC9-7E89-4D85-8390-6C703CEC60C0")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMMNotificationClient
    {
        /// <summary>
        /// Device State Changed
        /// </summary>
        [PreserveSig]
        void OnDeviceStateChanged(
            [MarshalAs(UnmanagedType.LPWStr)] String deviceId, 
            [MarshalAs(UnmanagedType.I4)] DeviceState newState);

        /// <summary>
        /// Device Added
        /// </summary>
        [PreserveSig]
        void OnDeviceAdded(
            [MarshalAs(UnmanagedType.LPWStr)] String pwstrDeviceId);

        /// <summary>
        /// Device Removed
        /// </summary>
        [PreserveSig]
        void OnDeviceRemoved(
            [MarshalAs(UnmanagedType.LPWStr)] String deviceId);

        /// <summary>
        /// Default Device Changed
        /// </summary>
        [PreserveSig]
        void OnDefaultDeviceChanged(
            DataFlow flow, 
            Role role,
            [MarshalAs(UnmanagedType.LPWStr)] String defaultDeviceId);

        /// <summary>
        /// Property Value Changed
        /// </summary>
        /// <param name="pwstrDeviceId"></param>
        /// <param name="key"></param>
        [PreserveSig]
        void OnPropertyValueChanged(
            [MarshalAs(UnmanagedType.LPWStr)] String pwstrDeviceId, 
            PropertyKey key);
    }
}
