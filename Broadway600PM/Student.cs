using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway600PM
{
    public class Student
    {
        public Student()
        {
            Name = "Some Name";
            Age = 20;
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }


        public static Student operator ++(Student s)
        {
            s.Age++;
            s.Weight++;
            return s;
        }

        public static Student operator --(Student s)
        {
            s.Age--;
            s.Weight++;
            return s;
        }

        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Name==s2.Name && s1.Age==s2.Age && s1.Weight==s2.Weight;
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return !(s1.Name == s2.Name && s1.Age == s2.Age && s1.Weight == s2.Weight);
        }

        public static Student operator +(Student s1, Student s2)
        {
            var sumAge = s1.Age + s2.Age;
            var sumName = s1.Name + " " + s2.Name;
            var sumWeight = s1.Weight + s2.Weight;

            return new Student { Age = sumAge, Name = sumName, Weight = sumWeight };
        }

    }



    public class TestModel
    {
        public TestModel(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
            
        }

        public string Name { get; set; }
        public string Address { get; set; }
    }
}
