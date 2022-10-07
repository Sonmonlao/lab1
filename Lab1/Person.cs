using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MethLab1
{
    class Person : IEquatable<Person>
    {
        protected string firstName;
        protected string lastname;
        protected System.DateTime dateBirth;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastname; } set { lastname = value; } }
        public System.DateTime DateBirth { get { return dateBirth; } set { dateBirth = value; } }
        public int YearBirth { get { return dateBirth.Year; } set { dateBirth =new DateTime(value, dateBirth.Month, dateBirth.Day); }  }

        public Person(string firstName, string lastname, DateTime dateBirth)
        {
            this.firstName = firstName;
            this.lastname = lastname;
            this.dateBirth = dateBirth;
        }

        public Person()
        {
            firstName = "Jone";
            lastname = "Doe";
            dateBirth = System.DateTime.Now;
        }
        
        public override string ToString()
        {
            string output = $"Имя: {firstName} Фамилия: {lastname} Дата рождения: {dateBirth}";
            return output;
        }

        public virtual string ToShortString()
        {
            string output = $"Имя: {firstName} Фамилия: {lastname}";
            return output;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person? other)
        {
            return other is not null &&
                   firstName == other.firstName &&
                   lastname == other.lastname &&
                   dateBirth == other.dateBirth;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(firstName, lastname, dateBirth);
        }
    }
}
