// <summary>
//   The program.
// </summary>

namespace Chloroplastiq
{
    using System;
    using System.Windows.Forms;

    using Chloroplastiq.UI;

    /// <summary>
    /// The program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Display());
        }
    }
}