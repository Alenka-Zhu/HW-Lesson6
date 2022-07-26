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
            str = str.Replace(" ", "");/*убрали пробелы*/
            str = str.ToLower();/*привели к нижнему регистру*/
            string str2 = "";/*завели переменную для перевернутой строки*/
            foreach (char c in str)/*перебираем str,прибавляя в str2 каждый последуюющий знак перед строкой,чтобы
                                    * получить перевертыш*/
            {
                str2 = c + str2;
            }
            Console.WriteLine(str2);/*вывели перевертыш*/
            if (String.Equals(str2, str))/*если строки равны, то выводим,что это палиндром
                                          * можно так же: if(str2==str)*/
            {
                Console.WriteLine("вы ввели палиндром");
            }
            else
                Console.WriteLine("это не палиндром");
            Console.ReadKey();
        }
    }
}
