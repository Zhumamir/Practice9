using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    class DVD : Storage
    {
        private double readWriteSpeed;
        private bool isDoubleLayer;

        public double ReadWriteSpeed { get => readWriteSpeed; set => readWriteSpeed = value; }
        public bool IsDoubleLayer { get => isDoubleLayer; set => isDoubleLayer = value; }


        public override double GetMemory()
        {
            return IsDoubleLayer ? 9 : 4.7;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Copying data to DVD. Size: {dataSize} GB");
        }

        public override double GetFreeSpace()
        {
            return GetMemory();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"DVD: {Name}, Model: {Model}, Read/Write Speed: {ReadWriteSpeed} GB/s, Double Layer: {IsDoubleLayer}, Memory Size: {GetMemory()} GB");
        }
    }
}
