﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting {
    class Program {
        static void Main(string[] args) {

            ArraySorter arsort = new ArraySorter();
            arsort.Sort();
            arsort.Print();
            Console.ReadLine();
        }
    }
}
