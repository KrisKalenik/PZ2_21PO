using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pz0427_EmptyForm
{
    class Program
    {
        public static void Main()
        {
            //Form form = new Form();
            //form.Text = "First Form";
            //form.Width = form.Height * 2;
            MainForm newForm = new MainForm();
            string temp = newForm.Version;
            //newForm.Version = null; //error

            Application.Run(new SecondForm());

            //form.Show();

            //System.Console.ReadLine();
        }
    }
}