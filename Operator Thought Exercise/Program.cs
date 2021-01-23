using System;

namespace Operator_Thought_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            x *= 5;

            var i = 3;
            var j = 4;
            var k = ++i * j++;

            int age = 7;
            int y = 4;

            bool isTeenager = age > 12 && age < 20;

            Console.WriteLine(k++);                        
            Console.WriteLine(k);
            Console.WriteLine(--k);
            Console.WriteLine(--k);
            Console.WriteLine(--k);

            Console.WriteLine(isTeenager);

            Console.WriteLine(x);


        }
    }
}

