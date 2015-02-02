using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CoreAudio.Net.Extensions
{
    public class MMDeviceEnumerator : IDisposable
    {
        public MMDeviceEnumerator()
        {
            this.deviceEnumerator = new CoreAudio.Net.MMDeviceEnumerator();
        }

        public IEnumerable<IMMDevice> GetAudioEndPoints(
            DataFlow dataFlow, 
            DeviceState deviceState)
        {
            IMMDeviceCollection devices = null;
            Int32 deviceCount;
            Int32 deviceIndex;
            IMMDevice device;

            try
            {
                this.deviceEnumerator.EnumAudioEndpoints(dataFlow, deviceState, out devices);
                devices.GetCount(out deviceCount);
                for (deviceIndex = 0; deviceIndex < deviceCount; deviceIndex++)
                {
                    devices.Item(deviceIndex, out device);
                    yield return device;
                }
            }
            finally
            {
                Marshal.ReleaseComObject(devices);
            }
        }

        public IMMDevice GetDefaultAudioEndPoint(
            DataFlow dataFlow, 
            Role role)
        {
            IMMDevice device;
            this.deviceEnumerator.GetDefaultAudioEndpoint(dataFlow, role, out device);
            return device;
        }

        public void Dispose()
        {
            if (deviceEnumerator != null)
            {
                Marshal.ReleaseComObject(deviceEnumerator);
                deviceEnumerator = null;
            }
        }

        private IMMDeviceEnumerator deviceEnumerator;
    }
}
