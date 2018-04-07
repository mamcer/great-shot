using System;
using System.Windows.Forms;

namespace GreatShot.UI
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                Error error = new Error(ex);
                error.ShowDialog();
            }

        }
    }
}