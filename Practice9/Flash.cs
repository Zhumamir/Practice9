using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    class Flash : Storage
    {
        private double usbSpeed;
        private double memorySize;

        public double UsbSpeed { get => usbSpeed; set => usbSpeed = value; }
        public double MemorySize { get => memorySize; set => memorySize = value; }

        public override double GetMemory()
        {
            return MemorySize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to Flash. Size: {dataSize} GB");
        }

        public override double GetFreeSpace()
        {
            return MemorySize - GetMemory();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Flash Drive: {Name}, Model: {Model}, USB Speed: {UsbSpeed} GB/s, Memory Size: {MemorySize} GB");
        }
    }
}
