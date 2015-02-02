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
    [Guid("0BD7A1BE-7A1A-44DB-8397-CC5392387B5E")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMMDeviceCollection
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numDevices"></param>
        /// <returns></returns>
        Int32 GetCount(
            out Int32 numDevices);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="deviceNumber"></param>
        /// <param name="device"></param>
        /// <returns></returns>
        Int32 Item(
            Int32 deviceNumber, 
            out IMMDevice device);
    }
}
