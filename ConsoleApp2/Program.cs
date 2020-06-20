using System;
using MyLib;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from C++");

            Person person = new Person( "Tom", 35 );
            Console.WriteLine(person.Name + " " + person.Age);
        }
    }
}
