using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Create(1);
            tree.Print();

            Console.ReadLine();
        }

    }
}
