namespace LabWork6
{
    using System;
    using System.Windows.Forms;

    using ComputerGraphics;

    internal static class Program
    {
        #region Methods

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ComputerGraphicsForm());
        }

        #endregion
    }
}
