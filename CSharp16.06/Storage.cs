using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp16._06
{
    public abstract class Storage
    {
        public string Model { get; set; }
        public string Name { get; set; }
        public double Memory { get; set; }

        public abstract double GetMemory();
        public abstract double GetSpeed();

        public abstract void CopyToFile();

        public abstract double GetFreeMemory();

        public abstract string ShowAllInfo();
    }
}