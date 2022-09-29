using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAnimalShelter {
    public class Dog:Animal {
        public Dog(string name) {
            this.sound = "Wouf";
            this.name = name;
        }
    }
}
