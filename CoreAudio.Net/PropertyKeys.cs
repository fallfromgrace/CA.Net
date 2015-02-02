using System;

namespace CoreAudio.Net
{
    /// <summary>
    /// 
    /// </summary>
    public static class PropertyKeys
    {
        /// <summary>
        /// 
        /// </summary>
        public static class AudioEndpoint
        {
            /// <summary>
            /// PKEY_AudioEndpoint_Association
            /// </summary>
            public static PropertyKey Association
            {
                get { return association; }
            }

            /// <summary>
            /// PKEY_AudioEndpoint_ControlPanelPageProvider
            /// </summary>
            public static PropertyKey ControlPanelPageProvider
            {
                get { return controlPanelPageProvider; }
            }

            /// <summary>
            /// PKEY_AudioEndpoint_Disable_SysFx
            /// </summary>
            public static PropertyKey DisableSystemEffects
            {
                get { return disableSystemEffects; }
            }

            /// <summary>
            /// PKEY_AudioEndpoint_FormFactor
            /// </summary>
            public static PropertyKey FormFactor
            {
                get { return formFactor; }
            }

            /// <summary>
            /// PKEY_AudioEndpoint_Full_Range_Speakers
            /// </summary>
            public static PropertyKey FullRangeSpeakers
            {
                get { return FullRangeSpeakers; }
            }

            /// <summary>
            /// PKEY_AudioEndpoint_GUID
            /// </summary>
            public static PropertyKey Guid
            {
                get { return guid; }
            }

            /// <summary>
            /// PKEY_AudioEndpoint_JackSubType
            /// </summary>
            public static PropertyKey JackSubType
            {
                get { return jackSubType; }
            }

            /// <summary>
            /// KEY_AudioEndpoint_PhysicalSpeakers
            /// </summary>
            public static PropertyKey PhysicalSpeakers
            {
                get { return physicalSpeakers; }
            }

            /// <summary>
            /// PKEY_AudioEndpoint_Supports_EventDriven_Mode
            /// </summary>
            public static PropertyKey SupportsEventDrivenMode
            {
                get { return supportsEventDrivenMode; }
            }

            /// <summary>
            /// 
            /// </summary>
            static AudioEndpoint()
            {
                association = new PropertyKey(new Guid(0x1da5d803, unchecked((short)0xd492), 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e), 2);
                controlPanelPageProvider = new PropertyKey(new Guid(0x1da5d803, unchecked((short)0xd492), 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e), 1);
                disableSystemEffects = new PropertyKey(new Guid(0x1da5d803, unchecked((short)0xd492), 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e), 5);
                formFactor = new PropertyKey(new Guid(0x1da5d803, unchecked((short)0xd492), 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e), 0);
                fullRangeSpeakers = new PropertyKey(new Guid(0x1da5d803, unchecked((short)0xd492), 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e), 6);
                guid = new PropertyKey(new Guid(0x1da5d803, unchecked((short)0xd492), 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e), 4);
                jackSubType = new PropertyKey(new Guid(0x1da5d803, unchecked((short)0xd492), 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e), 8);
                physicalSpeakers = new PropertyKey(new Guid(0x1da5d803, unchecked((short)0xd492), 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e), 3);
                supportsEventDrivenMode = new PropertyKey(new Guid(0x1da5d803, unchecked((short)0xd492), 0x4edd, 0x8c, 0x23, 0xe0, 0xc0, 0xff, 0xee, 0x7f, 0x0e), 7);
            }

            private static readonly PropertyKey association;
            private static readonly PropertyKey controlPanelPageProvider;
            private static readonly PropertyKey disableSystemEffects;
            private static readonly PropertyKey formFactor;
            private static readonly PropertyKey fullRangeSpeakers;
            private static readonly PropertyKey guid;
            private static readonly PropertyKey jackSubType;
            private static readonly PropertyKey physicalSpeakers;
            private static readonly PropertyKey supportsEventDrivenMode;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class AudioEngine
        {
            /// <summary>
            /// PKEY_AudioEngine_DeviceFormat
            /// </summary>
            public static PropertyKey DeviceFormat
            {
                get { return deviceFormat; }
            }

            /// <summary>
            /// PKEY_AudioEngine_OEMFormat
            /// </summary>
            public static PropertyKey OEMFormat
            {
                get { return oemFormat; }
            }

            /// <summary>
            /// 
            /// </summary>
            static AudioEngine()
            {
                deviceFormat = new PropertyKey(new Guid(unchecked((int)0xf19f064d), 0x82c, 0x4e27, 0xbc, 0x73, 0x68, 0x82, 0xa1, 0xbb, 0x8e, 0x4c), 0);
                oemFormat = new PropertyKey(new Guid(unchecked((int)0xe4870e26), 0x3cc5, 0x4cd2, 0xba, 0x46, 0xca, 0xa, 0x9a, 0x70, 0xed, 0x4), 3);
            }

            private static readonly PropertyKey deviceFormat;
            private static readonly PropertyKey oemFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class Device
        {
            /// <summary>
            /// PKEY_Device_FriendlyName
            /// </summary>
            public static PropertyKey FriendlyName
            {
                get { return friendlyName; }
            }

            /// <summary>
            /// 
            /// </summary>
            static Device()
            {
                friendlyName = new PropertyKey(new Guid(unchecked((int)0xa45c254e), unchecked((short)0xdf1c), 0x4efd, 0x80, 0x20, 0x67, 0xd1, 0x46, 0xa8, 0x50, 0xe0), 14);
            }

            private static readonly PropertyKey friendlyName;
        }

        /// <summary>
        /// 
        /// </summary>
        public static class DeviceInterface
        {
            /// <summary>
            /// PKEY_DeviceInterface_FriendlyName
            /// </summary>
            public static PropertyKey FriendlyName
            {
                get { return friendlyName; }
            }

            static DeviceInterface()
            {
                friendlyName = new PropertyKey(
                    new Guid(
                        0x026e516e, 
                        unchecked((Int16)0xb814), 
                        0x414b, 
                        0x83,
                        0xcd, 
                        0x85, 
                        0x6d, 
                        0x6f, 
                        0xef, 
                        0x48, 
                        0x22), 
                    2);
            }

            private static readonly PropertyKey friendlyName;
        }
    }
}
