using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_Validasi_angka_huruf
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int angka;

            Console.Write("Input apa saja :");
            a = Console.ReadLine();

            if (int.TryParse(a, out angka))
            {
                Console.WriteLine("angka");
            }
            else
            {
                Console.WriteLine("huruf");
            }
            Console.Read();
        }
    }
}
