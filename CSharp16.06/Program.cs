using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp16._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackupCopy backupCopy = new BackupCopy(1000, 326);
            Console.WriteLine(backupCopy.GetCountStorage(0));

            Console.ReadKey();
        }
    }
}
