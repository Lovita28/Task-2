using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_2_Evaluasi_Nilai
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Input your value :");
            a = int.Parse(Console.ReadLine());

            if (a > 80)
            {
                Console.WriteLine("Your grade is A");

            }
            else if (a >= 65 && a <= 80)
            {
                Console.WriteLine(" Your grade is B");
            }
            else if (a >= 45 && a < 65)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (a >= 30 && a < 40)
            {
                Console.WriteLine("Your grade is D");
            }
            else if (a < 30)
            {
                Console.WriteLine("Your grade is E");
            }

            Console.Read();
        }
    }
}
