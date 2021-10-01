using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTraingle
{
    class Triangle
    {
        public void addToArray(int num)
        {
            //Set i = 1, so that the number of printed input == num
            for (int i=1; i <= num; i++)
            {
                int temp = 0;
                int temp1 = 1;
                Console.Write(temp1+"\t");

                //Set J = 1, so that the number of printed input == num
                for (int j=1; j < i; j++)
                {
                    int temp2 = temp + temp1;
                   
                    Console.Write(temp2+"\t");

                    //Reset the 2 numbers to be added for the next iteration
                    temp = temp1;
                    temp1 = temp2;
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            Console.WriteLine("Enter array limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Thread s = new Thread(() => { t.addToArray(limit); });
            s.Start();

            Console.ReadLine();
        }
    }
}
