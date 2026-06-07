using System;
using System.Collections.Generic;

int my_number = 2;
string my_string = "Hello";

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 27;
            string name = "Konstantin";

            Console.WriteLine("Your name is: " + name + " and you are " + age + " years old");
            Console.WriteLine("Your age is: " + age);

        }
    }
}




for (int i = 0; i < my_number; i++)
{
    Console.WriteLine(my_string);
}

Console.WriteLine(my_string + ' ' + 2);
