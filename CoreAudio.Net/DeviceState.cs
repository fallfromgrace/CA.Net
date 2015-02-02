using System;

namespace CoreAudio.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum DeviceState
    {
        /// <summary>
        /// 
        /// </summary>
        Active = 1,

        /// <summary>
        /// 
        /// </summary>
        Unplugged = 2,

        /// <summary>
        /// 
        /// </summary>
        NotPresent = 4,

        /// <summary>
        /// 
        /// </summary>
        All = 7
    }
}
