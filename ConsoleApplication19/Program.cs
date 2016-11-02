using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[10];
            int i = 0;
            
            string[] text = { "0-9", "10-19","20-29", "30-39", "40-49", "50-59", "60-69", "70-79", "80-89", "90-99" };
            bool positive = true;
            while (positive)
            {
                Console.WriteLine("please enter the number");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == -1)
                {
                    positive = false;
                }
                else if (x >= 0 && x <= 100)
                {
                    i = x / 10;
                    ar[i] = ar[i] + 1;
                }
            }
            int counter = 0;
            foreach (int item in ar)
            {
                Console.Write(text[counter] +"      ");
                Console.WriteLine(new string('*', item));
                counter++;
            }


        }



    }
}

