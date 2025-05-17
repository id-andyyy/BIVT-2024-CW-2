using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CW_2.Var_00;

namespace CW2.Var00
{
    public class Task2 : ITask2
    {
        private string _input;
        private string _output;
        public string Input => _input;
        public string Output => _output;
        
        public Task2(string text)
        {
            _input = text;

            var endSymbols = new char[] { '.', '!', '?' };
            var symbols = new char[]
                { '.', '!', '?', ',', ':', '\'', ';', '–', '(', ')', '[', ']', '{', '}', '/', ' ' };

            var sentences = new List<string>();
            var sb = new StringBuilder();
            for (int i = 0; i < Input.Length; i++)
            {
                sb.Append(Input[i]);

                if (endSymbols.Contains(Input[i]))
                {
                    while (i + 1 < Input.Length && endSymbols.Contains(Input[i + 1]))
                    {
                        sb.Append(Input[i + 1]);
                        i++;
                    }
                    
                    sentences.Add(sb.ToString().Trim());
                    sb.Clear();
                }
            }
            
            int max = 0;
            foreach (var sentence in sentences)
            {
                var words = sentence.Split(symbols).Where(x => x != "").ToArray();
                if (words.Length > max)
                {
                    max = words.Length;
                    _output = sentence;
                }
            }
        }

        public override string ToString()
        {
            return $"{Input}{Environment.NewLine}{Output}";
        }
    }
}