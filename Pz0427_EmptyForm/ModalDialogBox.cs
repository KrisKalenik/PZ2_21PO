using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Pz0427_EmptyForm
{
    internal class ModalDialogBox: Form
    {
        CheckBox cbGrayShades;
        Button btnOk;
        Button btnCancel;

        public ModalDialogBox()
        {
            this.Text = "Background Color";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowInTaskbar = false;

            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(144, 56);
            this.AutoScaleDimensions = new Size(4, 8);
            this.AutoScaleMode = AutoScaleMode.Font;

            cbGrayShades = new CheckBox(); 
            this.Controls.Add(this.cbGrayShades);
            cbGrayShades.Text = "only gray shades";
            int left;
            int top;
            left = 16;
            top = 8;

            cbGrayShades.Location = new Point(left, top);

            cbGrayShades.AutoSize = true;

            Size size = new Size(48, 14);

            btnOk = new Button();
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Parent = this;
            btnOk.Location = new Point(left, top * 4);
            btnOk.Size = size;
            btnOk.DialogResult = DialogResult.OK;

            this.AcceptButton = btnOk;

            btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Parent = this;
            btnCancel.Location = new Point(80, top * 4);
            btnCancel.Size = size;
            btnCancel.DialogResult = DialogResult.Cancel;

            this.CancelButton = btnCancel;


        }

        public bool GrayShades
        {
            get { return cbGrayShades.Checked; }
            private set { cbGrayShades.Checked = value; }
        }
    }
}
