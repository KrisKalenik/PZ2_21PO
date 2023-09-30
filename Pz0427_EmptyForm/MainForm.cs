using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Pz0427_EmptyForm
{
    internal class MainForm: Form
    {
        private string version;

        public MainForm()
        {
            this.Text = "Main Form";
            this.BackColor = Color.AliceBlue;
            this.Font = new Font("Arial", 16, FontStyle.Bold);
            this.Size = new Size(this.Width * 2, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Click += OnClick;
            //this.Paint += MyPaint;
            this.Load += MyLoad;
        }

        #region HidenProperties
        public string Version
        {
            get { return version; }
            private set { if (String.IsNullOrEmpty(value))
                    throw new Exception("Value could not be empty"); 
                  version = value; 
            }
        }

        public string VersionAuto { get; set; }
        #endregion

        public virtual void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Click");
        }

        

        Random rnd = new Random();

        void MyPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.Clear(Color.FromArgb(rnd.Next(255), 
                                    rnd.Next(255), 
                                    rnd.Next(255)));
        }

        void MyLoad(object sender, EventArgs e)
        {
            //MessageBox.Show("Form Loaded");
        }
    }
}
