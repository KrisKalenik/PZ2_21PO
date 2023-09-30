using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Pz0427_EmptyForm
{
    internal class SecondForm: MainForm
    {
        TextBox textBox;
        ExtensionButton button;

        public SecondForm()
        {
            this.Load += MyLoad;
            int top;
            int left;
            int pad = 10;

            Button btn = new Button();
            btn.Text = "Button 1";
            btn.AutoSize = true;
            btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            left = (this.ClientSize.Width - btn.Width) / 2;
            top = pad * 2;

            btn.Location = new Point(left, top);

            this.Controls.Add(btn);

            btn.Click += ButtonClick;
            //btn.Parent = this;
            btn = null;

            btn = new Button();
            btn.Text = "Button 2";
            btn.AutoSize = true;
            btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            left = (this.ClientSize.Width - btn.Width) / 2;
            top = top + btn.Height + pad*2;

            btn.Location = new Point(left, top);
            btn.Enabled = false;

            btn.Click += ButtonClick;

            this.Controls.Add(btn);

            btn = null;

            textBox = new TextBox();
            textBox.Text = "Button";
            textBox.CharacterCasing = CharacterCasing.Upper;
            textBox.Width = 150;
            left = (this.ClientSize.Width - textBox.Width) / 2;
            top += pad * 5;
            textBox.Location = new Point(left, top);
            textBox.Focus();
            textBox.TextChanged += TextBoxTextChanged;
            this.Controls.Add(textBox);

            button = new ExtensionButton();
            button.Parent = this;
            button.ExtTextValue = textBox.Text;
            top += textBox.Height + pad * 2;
            button.Top = top;

            button.Click += ExtButtonClick;



        }

        void TextBoxTextChanged(object sender, EventArgs e)
        {
            button.ExtTextValue = textBox.Text;
        }

        public override void OnClick(object sender, EventArgs e)
        {
            //base.OnClick(sender, e);
            this.Size = new Size(900, 900);
        }

        void MyLoad(object sender, EventArgs e)
        {
            //MessageBox.Show("Second form Loaded");
        }

        private bool enableFirst = true;
        void ButtonClick(object sender, EventArgs e)
        {
            if (enableFirst)
                MessageBox.Show("Button 1 clicked");
            else
                MessageBox.Show("Button 2 clicked");

            //((Button)sender).Enabled = false;

            foreach (Control c in this.Controls)
                if ((c is Button) && c.Text.Contains("Button"))
                    c.Enabled = !c.Enabled;

            enableFirst = !enableFirst;

        }

        void ExtButtonClick(object sender, EventArgs e)
        {
            ModalDialogBox dlg = new ModalDialogBox();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Random rnd = new Random();
                int iShade = rnd.Next(255);

                if(dlg.GrayShades)
                {
                    this.BackColor = Color.FromArgb(
                        iShade, iShade, iShade);
                }
                else
                {
                    this.BackColor = Color.FromArgb(
                        iShade, rnd.Next(255), rnd.Next(255));
                }
            }
        }
    }
}
