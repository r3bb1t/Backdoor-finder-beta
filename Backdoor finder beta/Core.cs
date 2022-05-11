using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Security.WinTrust;

namespace Backdoor_finder_beta
{
    class Core
    {

        static public void FindUnsigned()
        {

            Process[] proclist = Process.GetProcesses();

                foreach(Process process in proclist)
                {
                Console.WriteLine("___ " + process.ProcessName + " ___");
                    try 
                    {
                        foreach (ProcessModule module in process.Modules)
                        {

                            if (!WinTrust.VerifyEmbeddedSignature(module.FileName))
                            {
                                Console.WriteLine(module.FileName);
                            }
                        }
                    }
                catch (Exception e) 
                {
                    Console.WriteLine("The following exception has occured:");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("\n");
                }
                   
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