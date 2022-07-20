using System;
using System.Windows.Forms;

namespace WinFormsEcologicalModel
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 view = new Form1();
            IController controller = new Controller(view);
            view.SetController(controller);
            Application.Run(view);
            controller.Terminate();
        }
    }
}
