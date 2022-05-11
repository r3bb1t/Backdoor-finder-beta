using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Security.WinTrust;


namespace Backdoor_finder_beta
{
    class Program
    {

        static void usage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("1 - List all unsigned processes");
        }

        static void Main()
        {
            int choice;

            usage();
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(choice);

            switch (choice)
            {
                case 1:
                    Core.FindUnsigned();
                    break;
            }

        }
    }
}