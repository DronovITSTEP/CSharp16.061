using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp16._06
{
    public interface IBackupCopy
    {
        List<Storage> Storages { get; }
        double GetAllMemory();
        void CopyToDevice();
        double TimeCopy();
        int GetCountStorage(int index);
    }
}