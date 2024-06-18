using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Automation_tasks
{
    internal class MouseScripts
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        public static void test()
        {
            // Move the cursor to the position (200, 200) on the screen
            SetCursorPos(500, 200);
        }
    }
}
