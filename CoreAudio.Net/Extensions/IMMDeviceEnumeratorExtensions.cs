using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Light.Windows.Interop.Com.CoreAudio.Extensions
{
    public static class IMMDeviceEnumeratorExtensions
    {
        public static IEnumerable<IMMDevice> EnumAudioEndPoints(
            this IMMDeviceEnumerator deviceEnumerator,
            DataFlow dataFlow, 
            DeviceState deviceStates)
        {
            IMMDeviceCollection devices;
            Int32 hr = deviceEnumerator
                .EnumAudioEndpoints(dataFlow, deviceStates, out devices);
            Int32 deviceCount;
            hr = devices.GetCount(out deviceCount);
            for (Int32 deviceIndex = 0; deviceIndex < deviceCount; deviceCount++)
            {
                IMMDevice device;
                hr = devices.Item(deviceIndex, out device);
                yield return device;
            }
        }
    }
}
