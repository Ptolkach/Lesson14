using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat cat = new Cat("Олег");
            cat.ShowInfo();
            Dog dog = new Dog("Полкан");
            dog.ShowInfo();
            Console.ReadKey();
            

        }
    }
}
