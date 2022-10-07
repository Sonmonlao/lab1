using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Test
    {
        public string Name { get; set;}
        public bool IsCompleted{ get; set;}

        public Test(string name, bool isCompleted)
        {
            Name = name;
            IsCompleted = isCompleted;
        }
        public Test()
        {
            Name = "Undefinded";
            IsCompleted = true;
        }
        public override string ToString()
        {
            string output = $"Предмет: {Name} Статус: {IsCompleted}";
            return output;
        }
    }
}
