using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication1
{
    class Program
    {   
        static void Main(string[] args)
{           bool r;
            string []s = File.ReadAllLines(@"X:\s.txt");
            do
            {
                foreach (var str in s)
                {   

                    var t = true;

                    for (int i = 0; i < str.Length / 2; i++)
                    {
                        if (str[i] != str[str.Length - (i + 1)])
                            t = false;
                        break;
                    }
                    if (t)
                        Console.WriteLine("{0} является палиндромом", str);
                    else
                        Console.WriteLine("{0} не является палиндромом", str);
                }
                Console.WriteLine("Продолжить? Да - 1, нет - 0 ");
                int pr = Int32.Parse(Console.ReadLine());
                if (pr == 1) r = true;
                else r = false;
                Console.Clear();
            }
            while (r == true);
                Console.ReadLine();
            
        }
    }
}
