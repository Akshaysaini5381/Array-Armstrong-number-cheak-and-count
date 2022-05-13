using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Armstrong_number_cheak_and_count
{
    class Program
    {
        static void Main(string[] args)
        {
            // armstrong number 1 153 370 370 
            int[] arr = new int[6];
            int Acount = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Enter the value of array:");
                arr[i] = int.Parse(Console.ReadLine());

                int rem;
                int cube;
                int result = 0;
                int temp = arr[i];
                int num = arr[i];
                while (temp != 0)
                {
                    rem = temp % 10;
                    cube = rem * rem * rem;
                    result = result + cube;
                    temp = temp / 10;
                }
                if (num == result)
                {
                    Console.WriteLine("Armstrong number :" + num);
                    Acount++;
                }
                else
                {
                    Console.WriteLine("not Armstrong number ");
                }
            }
            Console.WriteLine("Total number :" + Acount);
        }
    }
}
