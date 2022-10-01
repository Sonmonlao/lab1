using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethLab1
{
    class Exam
    {
        public string Name { get; set; }
        public int grade { get; set; }
        public System.DateTime DateTime { get; set; }

        public Exam(string name, int grade, DateTime dateTime)
        {
            Name = name;
            this.grade = grade;
            DateTime = dateTime;
        }

        public Exam()
        {
            Name = "Undefind";
            grade = 2;
            DateTime = DateTime.Now;
        }

        public override string ToString()
        {
            string output = $"Название: {Name} Оценка: {grade} Дата экзамена: {DateTime}";
            return output;
        }
    }
}
