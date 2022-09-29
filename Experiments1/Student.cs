using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments1 {
    public class Student:IComparable {
        string name;
        int age;
        float height;
        public Student(string name, int age, float height) {
            this.name = name;
            this.age = age;
            this.height = height;

        }
        public Student(int age, float height) {
            this.age = age;
            this.height = height;

        }
        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public override string ToString() {
            return string.Format(
                $"Name: {name}, Age: {age}, Height: {height}");
        }

        public int CompareTo(object obj) {
            Student other = (Student)obj;
            double t1 = Math.Sqrt((age * age) / height);
            double t2 = Math.Sqrt((other.age * other.age) / other.height);
            return t1.CompareTo(t2);
        }
    }
}
