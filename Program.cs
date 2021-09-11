using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напипшите слово: ");
            var str = Console.ReadLine();
            var len = str.Length;
            var t = true;

            for(int i=0; i< len/2; i++)
            {
                if (str[i] != str[len - (i + 1)])
                    t = false;
                break;
            }
            if (t )
            {
                Console.WriteLine("{0} является палиндромом", str);
            }
            else
            {
                Console.WriteLine("{0} не является палиндромом", str);
            }
            Console.ReadLine();
        }
    }
}
