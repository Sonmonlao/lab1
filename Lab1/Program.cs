using Lab1;
using System.Diagnostics;

namespace MethLab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var person1 = new Person("Orish", "Ducha", new DateTime(1950, 01, 01));
            var person2 = new Person("Mironov", "Ssanina", new DateTime(1950, 01, 01));

            Console.WriteLine(Object.ReferenceEquals(person2, person1));
            Console.WriteLine(person1 == person2);
            Console.WriteLine("хэш: \n{0}  \n{1}", person1.GetHashCode(), person2.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("\n");

            var student = new Student(new Person("Oleg", "Sosna", new DateTime(2000, 01, 01)), Education.Specialist, 151);
            student.AddExams(new Exam("\n OAiP", 5, new DateTime(2018, 9, 21)));
            student.AddTest(new Test("OAiP", true));
            Console.WriteLine(student.ToString());
            Console.WriteLine(student.Person);
            Console.WriteLine("\n");
            var studentClone = (Student)student.DeepCopy();
            student.Person.FirstName = "Danchick";
            student.Person.LastName = "Banda";
            Console.WriteLine(student.ToString());
            Console.WriteLine(studentClone.ToString());
            Console.WriteLine("\n");
            try
            {
                student.GroupNumber = 600;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\n");

            foreach (var task in student.GetResults())
                Console.WriteLine(task.ToString());

            foreach (var task in student.ExamsOver(3))
                Console.WriteLine(task.ToString());
            Console.ReadKey();
        }
    }
    public enum Education
    {
        Specialist,
        Bachelor,
        SecondEducation
    }
}
        
        
        
       
