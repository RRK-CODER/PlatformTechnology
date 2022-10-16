using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPart1
{
    public class MyForm:Form
    {
        public MyForm()
        {
            InitComponents();
        }
        private void InitComponents()
        {
            Text = "First application";
            ClientSize = new System.Drawing.Size(800, 50);
            CenterToScreen();
        }
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm());
        }
    }
}
