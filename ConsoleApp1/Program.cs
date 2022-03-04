using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string aylar = Console.ReadLine();
            switch (aylar)
            {
                case "yanvar": Console.WriteLine(31);
                    break;
                case "fevral":Console.WriteLine(29);
                    break;
                case "mart":
                    Console.WriteLine(31);
                    break;
                case "aprel":
                    Console.WriteLine(30);
                    break;
                case "may":
                    Console.WriteLine(31);
                    break;
                case "iyun":
                    Console.WriteLine(30);
                    break;
                case "iyul":
                    Console.WriteLine(31);
                    break;
                case "avqust":
                    Console.WriteLine(30);
                    break;
                case "sentyabir":
                    Console.WriteLine(31);
                    break;
                case "oktyabir":
                    Console.WriteLine(30);
                    break;
                case "noyabir":
                    Console.WriteLine(31);
                    break;
                case "dekabir":
                    Console.WriteLine(30);
                    break;
                default:Console.WriteLine("ble bir ay yoxdur");
                    break;





            }
            Console.Read();
        }
        
    }
}
