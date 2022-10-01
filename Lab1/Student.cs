using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MethLab1.Program;

namespace MethLab1
{
    class Student
    {
        private Person _person;
        private Education _education;
        private int _groupNumber;
        private Exam[] _exams;

        public Person Person { get { return _person; } set { _person = value; } }
        public Education Education { get { return _education; } set { _education = value; } }
        public int GroupNumber { get { return _groupNumber; } set { _groupNumber = value; } }
        public Exam[] Exams { get { return _exams; } set { _exams = value; } }


        public double AverageGrade { get
            {
                double sum = 0;
                for(int i = 0; i < _exams.Length; i++)
                {
                    sum += _exams[i].grade;
                }

                double result = sum / _exams.Length;
                return result;
            } }

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
            for(int i = 0; i < exams.Length; i++)
            {
                _exams[_exams.Length-1] = exams[i];
            }
        }

        public override string ToString()
        {
            string arr = "";
            for(int i = 0; i < _exams.Length; i++)
            {
                arr += _exams[0].ToString();
            }
            string output = $"{_person} {_education} {_groupNumber} {arr}";
            return output;
        }

        public virtual string ToShortString()
        {
            string output = $"{_person} {_education} {_groupNumber} {AverageGrade}";
            return output;
        }

        public Student(Person person, Education education, int groupNumber)
        {
            _person = person;
            _education = education;
            _groupNumber = groupNumber;
        }

        public Student()
        {
            _person = new Person();
            _education = Education.Specialist;
            _groupNumber = 0;
            _exams = new Exam[0];
        }
    }
}
