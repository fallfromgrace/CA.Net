using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CoreAudio.Net
{
    /// <summary>
    /// 
    /// </summary>
    [ComImport]
    [SuppressUnmanagedCodeSecurity]
    [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMMDeviceEnumerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataFlow"></param>
        /// <param name="stateMask"></param>
        /// <param name="devices"></param>
        /// <returns></returns>
        int EnumAudioEndpoints(
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
        int GetDefaultAudioEndpoint(
            DataFlow dataFlow, 
            Role role, 
            out IMMDevice endpoint);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deviceName"></param>
        /// <returns></returns>
        int GetDevice(
            string id, 
            out IMMDevice deviceName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        int RegisterEndpointNotificationCallback(
            IMMNotificationClient client);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        int UnregisterEndpointNotificationCallback(
            IMMNotificationClient client);
    }
}
