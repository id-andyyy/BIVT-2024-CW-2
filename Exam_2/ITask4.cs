using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CW_2.Var_00;

namespace CW2.Var00
{
    public interface ITask4
    {
        void Serialize(ITask1 obj, ITask3 path);
        ITask1 Deserialize(ITask3 path);
    }
}
