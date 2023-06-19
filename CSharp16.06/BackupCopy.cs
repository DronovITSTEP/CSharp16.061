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
        //private List<Storage> st;
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
        public double GetAllMemory()
        {
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
        public double TimeCopy()
        {
            double time = 0;
            //foreach (Storage storage in st)
            //{
            //    time += storage.Memory / storage.GetSpeed();
           // }
            return time * 2;
        }
        public int GetCountStorage(int index)
        {
            
            int count = 0;
            double size = _sizeBackup * 1024;
            while (size >= 0)
            {
                count++;
                while (Storages[index].GetFreeMemory() >= _sizeFile)
                {
                    Storages[index].Memory += _sizeFile;
                    size -= _sizeFile;
                    if (size < 0) break;
                    Console.WriteLine($"Memory = {Storages[index].Memory}\nSize = {size}\n" +
                        $"Free Memory = {Storages[index].GetFreeMemory()}");
                }
                Storages[index].Memory = 0;
            }
            return count;
        }
    }
}