using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = ReturnString("A string");
            Console.WriteLine($"string: {result}");

            result = ReturnString(27);
            Console.WriteLine($"int: {result}");

            result = ReturnString(27.78);
            Console.WriteLine($"double: {result}");

            result = ReturnString(41235.78M);
            Console.WriteLine($"decimal: {result}");

            result = ReturnString(true);
            Console.WriteLine($"bool: {result}");
        }

        private static string ReturnString<T>(T item)
        {
            return item.ToString();
        }
    }
}
