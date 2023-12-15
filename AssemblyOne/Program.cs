using AssemblyTwo;
using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Three classThree = new Three();
            classThree.name = "teste";
        }
    }


    class One
    {
        public string name; 
    }

    class Two
    {
        public string name; 
    }


}
