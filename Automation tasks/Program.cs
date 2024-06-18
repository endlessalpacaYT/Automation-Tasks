using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_tasks
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Automation Tasks";
            Console.Clear();
            Console.WriteLine("Welcome To Automation Tasks: V0.02 NOTE: THIS BUILD MAY NOT WORK WELL WITH SOME TASKS");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Use With Caution: ANY BUGS SHOULD BE REPORTED IMMEDIATELY");
            Console.WriteLine("Everthing Gets Tested Thoroughly So Major Bugs Should Already Be Addressed");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.Write("Loading");
            Thread.Sleep(3000);
            Console.Write(".");
            Thread.Sleep(1200);
            Console.Write(".");
            Thread.Sleep(1150);
            Console.Write(".");
            Thread.Sleep(1500);
            Tasks();
        }

        public static void Tasks()
        {
            Console.Clear();
            Console.WriteLine("What Automations Would You Like To Perform:");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Applications:");
            Console.WriteLine("1. Open TaskManager");
            Console.WriteLine("2. Open Explorer");
            Console.WriteLine("3. Open Settings");
            Console.WriteLine("4. Open Notepad");
            Console.WriteLine("5. Open CMD");
            Console.WriteLine("6 Open Microsoft Edge");
            Console.WriteLine("7. Open Wordpad");
            Console.WriteLine("8. Open Paint");
            Console.WriteLine("9. Open Calculator");
            Console.WriteLine("10. Open Windows Security");
            Console.WriteLine("11. Open Control Panel");
            Console.WriteLine("12. Open Microsoft Store");
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("Virtual KeyPress Scripts:");
            Console.WriteLine("13. Show Desktop");
            ChosenOption();
        }

        public static void ChosenOption()
        {
            Console.Write("--> ");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                System.Diagnostics.Process.Start("taskmgr");
                Tasks();
            }
            else if (option == 2)
            {
                System.Diagnostics.Process.Start("explorer");
                Tasks();
            }
            else if (option == 3)
            {
                System.Diagnostics.Process.Start("ms-settings:");
                Tasks();
            }
            else if (option == 4)
            {
                System.Diagnostics.Process.Start("notepad");
                Tasks();
            }
            else if (option == 5)
            {
                System.Diagnostics.Process.Start("cmd");
                Tasks();
            }
            else if (option == 6)
            {
                System.Diagnostics.Process.Start("microsoft-edge:");
                Tasks();
            }
            else if (option == 7)
            {
                System.Diagnostics.Process.Start("wordpad");
                Tasks();
            }
            else if (option == 8)
            {
                System.Diagnostics.Process.Start("mspaint");
                Tasks();
            }
            else if (option == 9)
            {
                System.Diagnostics.Process.Start("calc");
                Tasks();
            }
            else if (option == 10)
            {
                System.Diagnostics.Process.Start("WindowsDefender:");
                Tasks();
            }
            else if (option == 11)
            {
                System.Diagnostics.Process.Start("control");
                Tasks();
            }
            else if (option == 12)
            {
                System.Diagnostics.Process.Start("ms-windows-store:");
                Tasks();
            }
            else if (option == 13)
            {
                KeypressScripts.ShowDesktop();
                Tasks();
            }
            else
            {
                Console.WriteLine("Invalid Option");
                ChosenOption();
            }
        }
    }
}
