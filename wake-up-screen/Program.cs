using System;
using System.Threading;
using System.Runtime.InteropServices;


namespace wake_up_screen
{

    class Program
    {

        [DllImport("user32.dll")]
        public static extern long mouse_event(int flags, int x, int y, int data, IntPtr extraInfo);

        static void Main(string[] args)
        {
            mouse_event(0x0001, 0, 1, 0, (IntPtr)0);
        }
    }
}
