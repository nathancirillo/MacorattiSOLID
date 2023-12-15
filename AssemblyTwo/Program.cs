using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            Three three = new Three();
            three.name = "teste dois";
            Console.WriteLine(three.name);
        }
    }

    internal class Three
    {
        internal string name; 
    }

}
