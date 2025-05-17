using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CW_2.Var_00;

namespace CW2.Var00
{
    public class Task1 : ITask1
    {
        private string _input;
        private int _output;
        public string Input => _input;
        public int Output => _output;
        
        public Task1(string text)
        {
            _input = text;

            var symbols = new char[]
                { '.', '!', '?', ',', ':', '\'', ';', '–', '(', ')', '[', ']', '{', '}', '/', ' ' };

            var res = Input.Split(symbols).Where(x => x != "").ToArray();
            _output = res.Length;
        }

        public override string ToString()
        {
            return $"{Input}{Environment.NewLine}{Output}";
        }
    }
}