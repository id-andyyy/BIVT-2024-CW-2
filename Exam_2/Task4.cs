using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CW_2.Var_00;

namespace CW2.Var00
{
    public class Task4 : ITask4
    {
        public class Task1Dto
        {
            public string Input { get; set; }

            public static Task1Dto ToDto(ITask1 task1)
            {
                return new Task1Dto
                {
                    Input = task1.Input,
                };
            }

            public Task1 FromDto()
            {
                return new Task1(Input);
            }
        }
        
        public void Serialize(ITask1 obj, ITask3 path)
        {
            var js = JsonSerializer.Serialize(Task1Dto.ToDto(obj));
            string filePath = Path.Combine(path.FolderPath, "Task4.json");
            File.WriteAllText(filePath, js);
        }

        public ITask1 Deserialize(ITask3 path)
        {
            string filePath = Path.Combine(path.FolderPath, "Task4.json");
            if (!File.Exists(filePath))
            {
                return null;
            }

            return JsonSerializer.Deserialize<Task1Dto>(File.ReadAllText(filePath)).FromDto();
        }
    }
}