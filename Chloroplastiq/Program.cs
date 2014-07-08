namespace Chloroplastiq
{
    using System;
    using System.Windows.Forms;
    using UI;

    internal static class Program
    {

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Display());
        }
    }
}