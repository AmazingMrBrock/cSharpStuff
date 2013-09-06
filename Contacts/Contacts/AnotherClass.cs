using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contacts
{
    class AnotherClass
    {
        public static void Main()
        {
            MessageBox.Show("Pow!");
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
