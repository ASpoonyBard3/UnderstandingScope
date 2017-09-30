using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";


        static void Main(string[] args)
        {

            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = j.ToString();
                Console.WriteLine(i);

                if (i == 9);
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l);

            }
            //Console.WriteLine(i);
            Console.WriteLine("Out of the for: " + j);
            Console.WriteLine("Out of the for: " + k);

            HelperMethod();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("The value of k, from the helperMethod():" + k);
        }
    }
}
