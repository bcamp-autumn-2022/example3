using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname;
            int x;
            Console.WriteLine("What is your name?");
            fname=Console.ReadLine();
            Console.WriteLine("How are you,"+fname);
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Row is " + i);
                x = 2 * i;
            }
        }
    }
}
