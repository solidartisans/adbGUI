namespace adbGUI
{
    using System;
    using System.Windows.Forms;
    using Forms;
    using Methods;

    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            

            try
            {
                Dependencies.Check();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}