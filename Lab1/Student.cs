using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Lab1;

namespace MethLab1
{
    class Student : Person, IDateAndCopy
    {
        
        private Education _education;
        private int _groupNumber;
        private ArrayList _exams;
        private ArrayList _test;
        private Person _person;

        public Person Person { get { return (Person)this; } set { firstName = value.FirstName; lastname = value.LastName;dateBirth = value.DateBirth; } }
        public Education Education { get { return _education; } set { _education = value; } }
        public int GroupNumber { get { return _groupNumber; } set {
                if (value <= 100 || value > 599)
                {
                    throw new ArgumentOutOfRangeException("GroupNumber выходит за допустимые границы (100, 599).");
                }
                _groupNumber = value; } }
        public ArrayList Exams{get { return _exams; }set {_exams = value; } }
        


        public double AverageGrade { get
            {
                int sum = 0;
                foreach (Exam exam in _exams)
                {
                    sum = sum + exam.grade;
                }
                return (double)sum / _exams.Count;
            } }

        public DateTime Date { get ; set; }

        public bool this [Education index]
        {
            get
            {
                if (index == _education)
                {
                    return true;
                }
                else return false;
            }
        }

        public void AddExams(params Exam[] exams)
        {
            for (int i = 0; i < exams.Length; i++)
            {
                _exams.Add(exams[i]);
            }
                
        }
        public void AddTest(params Test[] test)
        {
            for (int i = 0; i < test.Length; i++)
            {
                _test.Add(test[i]);
            }
           
        }


        public override string ToString()
        {
            string arr = "";
            for(int i = 0; i < _exams.Count; i++)
            {
                arr += _exams[i].ToString();
            }
            string output = $"{firstName} {lastname} {DateBirth} {_education} {_groupNumber} {arr}";
            return output;
        }

        public virtual string ToShortString()
        {
            string output = $"{Person.FirstName}{Person.LastName} {Person.DateBirth}  {_education} {_groupNumber} {AverageGrade}";
            return output;
        }

        public object DeepCopy()
        {
            var student = new Student(_person, _education, _groupNumber);
            student._test = _test;
            student._exams = _exams;
            return student;
        }
        public IEnumerable GetResults()
        {
            foreach (var exam in _exams)
                yield return exam;
            foreach (var test in _test)
                yield return test;
        }

        public IEnumerable ExamsOver(int minRate)
        {
            foreach (var exam in _exams)
            {
                Exam ex = (Exam)exam;
                if (ex.grade > minRate)
                    yield return exam;
            }
        }

        public Student(Person person, Education education, int groupNumber)
        {
            _education = education;
            _person = person;
            _groupNumber = groupNumber;
            _exams= new ArrayList();
            _test= new ArrayList();
        }

        public Student()
        {
            _education = Education.Specialist;
            _person = new Person();
            _groupNumber = 4126;
            _exams= new ArrayList();
            _test=new ArrayList();
        }
    }
}
