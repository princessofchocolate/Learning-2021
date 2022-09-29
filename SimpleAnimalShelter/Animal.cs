using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAnimalShelter {
    public class Animal {
        public string name;
        protected string sound;
        private string someVariable = "you shouldn't see this";
        protected string MakeSound() {
            return this.sound;
        }

        public virtual void Print() { 
            Console.WriteLine($"{name} says: {MakeSound()}");
        }
    }
}
