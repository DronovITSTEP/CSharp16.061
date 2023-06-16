using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp16._06
{
    public class BackupCopy : IBackupCopy
    {
        private double _sizeBackup;
        private double _sizeFile;
        private List<Storage> st;
        public List<Storage> Storages { get; set; }

        public BackupCopy(double sBackup, double sFile)
        {
            Storages = new List<Storage>{
                new Flash
                {
                    Name = "USB-flash 3.0",
                    Model = "Kingston",
                    MemorySize =64
                },
                    new DVD
                    {
                        Name = "DVD-Disk",
                        Model = "Sony",
                        TypeDisk = "single"
                    },
                    new HDD {
                        Name = "HDD-Disk",
                        Model = "WesternDigital",
                        CountSection = 2,
                        MemorySection = 150
                    }
            };
            _sizeBackup = sBackup;
            _sizeFile = sFile;
        }
        public double GetAllMemory() {
            double totalMemory = 0;
            foreach (Storage storage in Storages)
            {
                totalMemory += storage.GetMemory();
            }
            return totalMemory;
        }
        public void CopyToDevice() 
        {
            // возврат строк процесса копирования (использовать рекурсию)
        }
        public double TimeCopy() {
            double time = 0;
            foreach (Storage storage in st)
            {
                time += storage.Memory / storage.GetSpeed();
            }
            return time * 2;
        }
        public int GetCountStorage(int index) {
            st = new List<Storage>();
            double size = _sizeBackup * 1024;
            while (size >= 0)
            {
                st.Add(Storages[index]);
                while (st.Last().GetFreeMemory() >= _sizeFile)
                {
                    st.Last().Memory += _sizeFile;
                    size -= _sizeFile;
                }                
            }
            return st.Count;
        }
    }
}