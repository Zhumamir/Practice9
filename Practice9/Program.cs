using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    class Program
    {
        static void Main()
        {
            Storage[] devices = new Storage[]
            {
            new Flash { Name = "Flash1", Model = "Model1", UsbSpeed = 3.0, MemorySize = 64 },
            new DVD { Name = "DVD1", Model = "Model2", ReadWriteSpeed = 8.0, IsDoubleLayer = false },
            new HDD { Name = "HDD1", Model = "Model3", UsbSpeed = 2.0, PartitionsCount = 2, PartitionSize = 500 }
            };

            double totalMemory = CalculateTotalMemory(devices);
            Console.WriteLine($"Total Memory: {totalMemory} GB");

            double dataSize = 565;
            CopyDataToDevice(devices, dataSize);

            double copyingTime = CalculateCopyingTime(devices, dataSize);
            Console.WriteLine($"Copying Time: {copyingTime} hours");

            CalculateRequiredDevices(dataSize, devices);
        }

        static double CalculateTotalMemory(Storage[] devices)
        {
            double totalMemory = 0;
            foreach (var device in devices)
            {
                totalMemory += device.GetMemory();
            }
            return totalMemory;
        }

        static void CopyDataToDevice(Storage[] devices, double dataSize)
        {
            foreach (var device in devices)
            {
                device.CopyData(dataSize);
            }
        }

        static double CalculateCopyingTime(Storage[] devices, double dataSize)
        {
            double totalSpeed = 0;
            foreach (var device in devices)
            {
                totalSpeed += device.GetMemory();
            }
            return dataSize / totalSpeed;
        }

        static void CalculateRequiredDevices(double dataSize, Storage[] devices)
        {
            foreach (var device in devices)
            {
                double requiredDevices = dataSize / device.GetMemory();
                Console.WriteLine($"Required {device.GetType().Name}s: {Math.Ceiling(requiredDevices)}");
            }
        }
    }
}
