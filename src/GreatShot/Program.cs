using System;
using System.Threading;
using System.Windows.Forms;

namespace GreatShot.UI
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += ApplicationOnThreadException;
            Application.Run(new MainForm());
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs threadExceptionEventArgs)
        {
            Error error = new Error(threadExceptionEventArgs.Exception);
            error.ShowDialog();
        }
    }
}