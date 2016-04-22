using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AndreyTools.TimeClicker
{
     class MouseClickProperties
     {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);

        public static void DoMouseClick(int posX, int posY)
        {
            SetCursorPos(posX, posY);
            mouse_event(Constants.MOUSEEVENTF_LEFTDOWN | Constants.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            
        }
    }
}
