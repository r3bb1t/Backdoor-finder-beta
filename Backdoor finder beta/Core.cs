using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Backdoor_finder_beta
{
    class Core
    {

        static public void ListProcesses()
        {
            Process[] processCollection = Process.GetProcesses();
            foreach (Process p in processCollection)
            {
                Console.WriteLine("___ " + p.ProcessName + " ___");
                show_modules(p);
                Console.WriteLine("\n");
            }
        }

        static void show_modules(Process p)
        {
            try
            {
                foreach (ProcessModule module in p.Modules)
                {
                    Console.WriteLine(module.FileName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Exception occured while trying to enumerate modules");
            }
        }
    }
}