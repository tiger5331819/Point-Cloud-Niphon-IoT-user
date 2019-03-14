using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EVCS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        //[DllImport("User32.dll")]
        //private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        //[DllImport("User32.dll")]
        //private static extern bool SetForegroundWindow(IntPtr hWnd);
        //private const int WS_SHOWNORMAL = 1;
        static void Main()
        {
            //Process instance = RunningInstance();
            //if (instance != null)
            //{
            //    HandleRunningInstance(instance);
            //    return;
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NewMain());   
        }

        /// <summary>
        /// 唯一进程
        /// </summary>
        /// <returns></returns>
        //private static Process RunningInstance()
        //{
        //    Process current = Process.GetCurrentProcess();
        //    Process[] processes = Process.GetProcessesByName(current.ProcessName);
        //    //遍历与当前进程名称相同的进程列表 
        //    foreach (Process process in processes)
        //    {
        //        //如果实例已经存在则忽略当前进程 
        //        if (process.Id != current.Id)
        //        {
        //            //保证要打开的进程同已经存在的进程来自同一文件路径
        //            if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
        //            {
        //                return process;
        //            }
        //        }
        //    }
        //    return null;
        //}
        //private static void HandleRunningInstance(Process instance)
        //{
        //   ShowWindowAsync(instance.MainWindowHandle, 1); 
        //   SetForegroundWindow(instance.MainWindowHandle); 
        //}

    }
}
