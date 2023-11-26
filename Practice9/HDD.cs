using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    class HDD : Storage
    {
        private double usbSpeed;
        private int partitionsCount;
        private double partitionSize;

        public double UsbSpeed { get => usbSpeed; set => usbSpeed = value; }
        public int PartitionsCount { get => partitionsCount; set => partitionsCount = value; }
        public double PartitionSize { get => partitionSize; set => partitionSize = value; }
        public override double GetMemory()
        {
            return partitionsCount * partitionSize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to HDD. Size: {dataSize} GB");
        }

        public override double GetFreeSpace(double dataSize)
        {
            return GetMemory() - dataSize;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"HDD: {Name}, Model: {Model}, USB Speed: {UsbSpeed} GB/s, Partitions: {PartitionsCount}, Partition Size: {PartitionSize} GB, Memory Size: {GetMemory()} GB");
        }
    }
}
