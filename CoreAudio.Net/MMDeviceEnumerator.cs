using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CoreAudio.Net
{
    /// <summary>
    /// implements IMMDeviceEnumerator
    /// </summary>
    [ComImport]
    [Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
    public class MMDeviceEnumerator : IMMDeviceEnumerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataFlow"></param>
        /// <param name="stateMask"></param>
        /// <param name="devices"></param>
        /// <returns></returns>
        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 EnumAudioEndpoints(
            DataFlow dataFlow, 
            DeviceState stateMask,
            out IMMDeviceCollection devices);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataFlow"></param>
        /// <param name="role"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 GetDefaultAudioEndpoint(
            DataFlow dataFlow, 
            Role role, 
            out IMMDevice endpoint);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deviceName"></param>
        /// <returns></returns>
        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 GetDevice(
            string id, 
            out IMMDevice deviceName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 RegisterEndpointNotificationCallback(
            IMMNotificationClient client);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        [PreserveSig]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        public extern Int32 UnregisterEndpointNotificationCallback(
            IMMNotificationClient client);
    }

}
