using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CW_2.Var_00;

namespace CW2.Var00
{
    public class Task2 : ITask1
    {
        private string _input;
        private int _output;
        public string Input => _input;
        public int Output => _output;
        
        public Task2(string text)
        {
            _input = text;

            var endSymbols = new char[] { '.', '!', '?' };
            var symbols = new char[]
                { '.', '!', '?', ',', ':', '\'', ';', '–', '(', ')', '[', ']', '{', '}', '/', ' ' };

            var sentences = Input.Split(endSymbols);
            int max = 0;
            foreach (var sentence in sentences)
            {
                var words = sentence.Split(symbols).Where(x => x != "").ToArray();
                max = Math.Max(max, words.Length);
            }

            _output = max;
        }

        public override string ToString()
        {
            return $"{Input}{Environment.NewLine}{Output}";
        }
    }
}