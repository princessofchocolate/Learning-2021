using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAnimalShelter {
    public class Lion:Animal {
        public Lion(string name) {
            this.sound = "Roar";
            this.name = name;
        }

        public override void Print() {
            Console.WriteLine($"OMG! {name} says: {MakeSound()}");


        }

    }
}
