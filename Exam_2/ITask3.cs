using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2.Var00
{
    public interface ITask3
    {
        string FolderPath { get; }
        string FilePath { get; }
        void Clear();
        void Copy(string newPath);
    }
}
