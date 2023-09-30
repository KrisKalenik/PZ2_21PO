using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Pz0427_EmptyForm
{
    internal class ExtensionButton:Button
    {
        private const int MIN_DISABLED = 5;
        public ExtensionButton()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        public string ExtTextValue
        {
            set
            {
                this.Text = value;
                bool enabled = value != null && value.Length > MIN_DISABLED;
                this.Enabled = enabled;

                if (this.Parent != null)
                {
                    int left = (this.Parent.ClientSize.Width - this.Width) / 2;
                    this.Left = left;
                }
            }
        }

    }
}
