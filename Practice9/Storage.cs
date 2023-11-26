using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    abstract class Storage
    {
        private string name;
        private string model;

        public string Name { get => name; set => name = value; }
        public string Model { get => model; set => model = value; }

        public abstract double GetMemory();
        public abstract void CopyData(double dataSize);
        public abstract double GetFreeSpace();
        public abstract void DisplayInfo();
    }
}
