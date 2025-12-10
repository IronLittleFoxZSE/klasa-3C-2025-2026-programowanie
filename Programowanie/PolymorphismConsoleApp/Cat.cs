using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConsoleApp
{
    class Animal
    {

    }

    internal class Cat: Animal, IWorkOnFiles
    {
        int age;

        public Cat()
        {
            age = 15;
        }

        public void Meow()
        {
            Console.WriteLine("Kot miałczy");
        }

        public virtual void SaveToFile()
        {

        }
    }
}
