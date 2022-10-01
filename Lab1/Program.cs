using System.Diagnostics;

namespace MethLab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.ToShortString());
            Console.WriteLine($"{student[Education.Specialist]},{student[Education.Bachelor]},{student[Education.SecondEducation]}");
            student.Person.FirstName = "Oleg";
            student.Person.LastName = "Sosna";
            student.Person.DateBirth = new DateTime(2004,07,12);
            student.Education = Education.Specialist;
            student.GroupNumber = 1;
            Exam exam1 = new Exam("OaIP",5,new DateTime(2022,12,17,13,30,0));
            student.Exams = new Exam[1];
            student.AddExams(exam1);
            
            Console.WriteLine(student.ToString());


            var linearArray = new Exam[1000000];
            var rectArray = new Exam[1000, 1000];
            var jaggedArray = new Exam[1000][];

            for (int i = 0; i < jaggedArray.Length; i++)
                jaggedArray[i] = new Exam[1000];

            var sw = Stopwatch.StartNew();

            for (int i = 0; i < 1000000; i++)
                linearArray[i] = null;

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw = Stopwatch.StartNew();

            for (int i = 0; i < 1000; i++)
                for (int j = 0; j < 1000; j++)
                    rectArray[i, j] = null;

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw = Stopwatch.StartNew();

            for (int i = 0; i < 1000; i++)
                for (int j = 0; j < 1000; j++)
                    jaggedArray[i][j] = null;
            sw.Stop();
            Console.WriteLine(sw.Elapsed);


        }
    }
        
        public enum Education
        {
            Specialist,
            Bachelor,
            SecondEducation
        }
       
}