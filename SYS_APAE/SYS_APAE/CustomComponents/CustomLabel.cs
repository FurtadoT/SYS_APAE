using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomLabel : Label
    {
        private bool txtBorder, txtTag;

        public CustomLabel(bool txtBorder = false, bool txtTag = false)
        {
            TxtBorder = txtBorder;
            TxtTag = txtTag;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            if (TxtBorder)
            {
                this.Height = 1;
                this.Dock = DockStyle.Bottom;
                this.BackColor = Color.Black;
            }
            else if (TxtTag)
            {
                AutoSize = true;
                Dock = DockStyle.None;
                Font = new Font("", 9F);
                Location = new Point(-2, 10);
            }

            base.OnHandleCreated(e);
        }

        public void changeColorFocus(bool isFocused)
        {
            if (isFocused)
            {
                if (TxtBorder)
                    this.BackColor = Color.BlueViolet;
                else if (TxtTag)
                    this.ForeColor = Color.BlueViolet;
            }
            else
            {
                if (TxtBorder)
                    this.BackColor = Color.Black;
                else if (TxtTag)
                    this.ForeColor = Color.Black;
            }
        }

        public void changeFocus(bool isFocused)
        {
            if (isFocused)
            {
                this.Location = new Point(-2, 0);
                this.Font = new Font("", 7F);
            }
            else
            {
                this.Location = new Point(-2, 10);
                this.Font = new Font("", 9F);
            }
        }

        public bool TxtBorder
        {
            get
            {
               return this.txtBorder;
            }
            set
            {
                this.txtBorder = value;
            }
        }
        public bool TxtTag
        {
            get
            {
                return this.txtTag;
            }
            set
            {
                this.txtTag = value;
            }
        }
    }
}
