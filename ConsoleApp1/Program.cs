using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = "";
            foreach (char c in str)
            {
                str2 = c + str2;
            }
            Console.WriteLine(str2);
            if (String.Equals(str2, str))
            {
                Console.WriteLine("вы ввели палиндром");
            }
            else
                Console.WriteLine("это не палиндром");
            Console.ReadKey();
        }
    }
}
