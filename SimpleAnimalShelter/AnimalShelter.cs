using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAnimalShelter {
    public class AnimalShelter {

        Animal[] animals = new Animal[10];
        public void FillShelter() {
            animals[0] = new Cat("Tom");
            animals[1] = new Cat("Pearl");
            animals[2] = new Cat("Sylvester");
            animals[3] = new Dog("Spike");
            animals[4] = new Dog("Rex");
            animals[5] = new Lion("Simba");
            animals[6] = new Lion("Mufasha");
        }

        public void Print() {
            
            for(int i = 0; i< animals.Length; i++) {
                if (animals[i] == null) continue;
                animals[i].Print();
            }
        }
    }
}
