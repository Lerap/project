using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3семестр._2лаба_шарп_
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Console.WriteLine("The program is starting");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
