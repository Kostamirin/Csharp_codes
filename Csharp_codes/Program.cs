using System;
using System.Collections.Generic;
using System.Text;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            
            int age = 27;
            string name = "Konstantin";

            // Интерполяция вывода
            Console.WriteLine("Your name is: " + name + " and you are " + age + " years old");
            Console.WriteLine($"Your name is: {name} and you are {age} years old");
            Console.WriteLine();

            
            // Конвертация значений
            int test_age = 15;
            string test_input = "15";

            test_input = test_input + Convert.ToString(test_age);
            test_age += Convert.ToInt32(test_input);
            
            Console.WriteLine(test_age);
            Console.WriteLine(test_input);
            Console.WriteLine();
            
                //! Важно отметить
                float result;
                int x=5, y=2;
                result = Convert.ToSingle(x) / y;
                Console.WriteLine(result);
            
            
            // Some for/foreach stuff
            int[] values = { 10, 20, 30, 40, 50 };
            Console.WriteLine("For loop output:");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"Index {i}: {values[i]}");
            }

            Console.WriteLine("Foreach loop output:");
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
            
            // User input
            string user_name;
            int user_age;
            Console.Write("Enter you name, dear user: ");
            user_name = Console.ReadLine();
            Console.Write("Enter your age: ");
            user_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hello there {user_name}! How is this feel to be {user_age-1} years old?");
            
            //Console.ReadKey();
        }
    }
}