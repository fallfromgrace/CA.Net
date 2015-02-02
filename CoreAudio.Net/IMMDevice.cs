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
    [Guid("D666063F-1587-4E43-81F1-B948E807363F")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMMDevice
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clsCtx"></param>
        /// <param name="activationParams"></param>
        /// <param name="interfacePointer"></param>
        /// <returns></returns>
        [PreserveSig]
        Int32 Activate(
            ref Guid id, 
            ClsCtx clsCtx, 
            IntPtr activationParams,
            [MarshalAs(UnmanagedType.IUnknown)] out Object interfacePointer);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stgmAccess"></param>
        /// <param name="properties"></param>
        /// <returns></returns>
        [PreserveSig]
        Int32 OpenPropertyStore(
            StorageAccessMode stgmAccess, 
            out IPropertyStore properties);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [PreserveSig]
        Int32 GetId(
            [MarshalAs(UnmanagedType.LPWStr)] out String id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        [PreserveSig]
        Int32 GetState(
            out DeviceState state);
    }
}
