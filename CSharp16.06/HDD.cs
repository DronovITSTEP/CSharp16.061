using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp16._06
{
    public class HDD : Storage
    {
        private const double _USB2_0_Speed = 35;
        public int CountSection { get; set; }
        public double MemorySection { get; set; }

        public override void CopyToFile()
        {
            throw new NotImplementedException();
        }

        public override double GetFreeMemory(double size)
        {
            throw new NotImplementedException();
        }

        public override double GetMemory()
        {
            return CountSection * MemorySection;
        }

        public override double GetSpeed()
        {
            return _USB2_0_Speed;
        }

        public override string ShowAllInfo()
        {
            throw new NotImplementedException();
        }
    }
}