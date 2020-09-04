using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckBinaryNumber();
            Console.Read();
        }
        private static void CheckBinaryNumber()
        {
            try
            {
                Console.WriteLine("Please input any binary number.");
                int val = Convert.ToInt32(Console.ReadLine(), 2);
                int count0 = 0, count1 = 0;
                String bin = "";
                while (val > 0)
                {
                    if (val % 2 == 1)
                    {
                        bin += '1';
                        count1++;
                    }
                    else
                    {
                        bin += '0';
                        count0++;
                    }
                    val /= 2;
                }
                if (count0 == count1)
                { Console.WriteLine("Good Binary"); }
                else
                {
                    Console.WriteLine("Bad Binary");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter valid binary input eg. 110010");
            }
        }
    }
}
