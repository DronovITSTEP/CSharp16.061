using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp16._06
{
    public class DVD : Storage
    {

        private const double _readSpeed = 1.32;
        private const double _writeSpeed = 1.32;
        private double[] sizeDisk = { 4.7, 9 };
        private int index;

        private string _typeDisk;
        public string TypeDisk
        {
            get { return _typeDisk; }
            set
            {
                if (value == "single")
                    index = 0;
                else if (value == "double")
                    index = 1;
                else
                    throw new ArgumentException("Неверные данные");
                _typeDisk = value;
            }
        }



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
            return sizeDisk[index];
        }

        public override double GetSpeed()
        {
            return _readSpeed;
        }

        public override string ShowAllInfo()
        {
            throw new NotImplementedException();
        }
    }
}