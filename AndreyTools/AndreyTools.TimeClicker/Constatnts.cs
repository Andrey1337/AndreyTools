using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyTools.TimeClicker
{
    public static class Constants
    {
        //modifiers
        public const int NOMOD = 0x0000;
        public const int ALT = 0x0001;
        public const int CTRL = 0x0002;
        public const int SHIFT = 0x0004;
        public const int WIN = 0x0008;

        public const int MOUSEEVENTF_MOVE = 0x0001;     /* mouse move */
        public const int MOUSEEVENTF_LEFTUP = 0x04;     /* left button up */
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;   /* left button down */
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;  /* right button down */
        public const int MOUSEEVENTF_RIGHTUP = 0x10;    /* right button up */


        //windows message id for hotkey
        public const int WM_HOTKEY_MSG_ID = 0x0312;
    }

}
