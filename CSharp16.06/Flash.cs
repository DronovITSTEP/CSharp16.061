using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp16._06
{
    public class Flash : Storage
    {
        private const double _USB3_0_Speed  = 625;
        private const double _size = 64;
        public double MemorySize { get; set; }

        public override void CopyToFile()
        {
            throw new NotImplementedException();
        }

        public override double GetFreeMemory()
        {         
            return _size*1024 - Memory;
        }

        public override double GetMemory()
        {
            return Memory;
        }

        public override double GetSpeed()
        {
            return _USB3_0_Speed;
        }

        public override string ShowAllInfo()
        {
            throw new NotImplementedException();
        }
    }
}