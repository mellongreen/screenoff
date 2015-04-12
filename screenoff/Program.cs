<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace screenoff
{
    public class Program
    {
        private static int SC_MONITORPOWER = 0xF170;

        private static uint WM_SYSCOMMAND = 0x0112;

        [DllImport("user32.dll")]

        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);


        enum MonitorState
        {
            ON = -1,
            OFF = 2,
            STANDBY = 1
        }
        private static void SetMonitorState(MonitorState state)
        {
            Form frm = new Form();

            SendMessage(frm.Handle, WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (IntPtr)state);

        }
        public static void Main(String[] args)
        {
            SetMonitorState(MonitorState.OFF);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace screenoff
{
    public class Program
    {
        private static int SC_MONITORPOWER = 0xF170;

        private static uint WM_SYSCOMMAND = 0x0112;

        [DllImport("user32.dll")]

        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);


        enum MonitorState
        {
            ON = -1,
            OFF = 2,
            STANDBY = 1
        }
        private static void SetMonitorState(MonitorState state)
        {
            Form frm = new Form();

            SendMessage(frm.Handle, WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (IntPtr)state);

        }
        public static void Main(String[] args)
        {
            SetMonitorState(MonitorState.OFF);
        }
    }
}
>>>>>>> e385d9896cb60985549cff54f71c888c59ef8905
