using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;


namespace spapiApp
{
    static class Program
    { 
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] pro = Process.GetProcesses(); 
            if (pro.Where(a => a.ProcessName == "a1").Count() > 1) { }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            Application.Run(new Login());


        }
    }
}
