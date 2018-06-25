using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomLabel : Label
    {
        private bool txtBorder, txtTag, txtError, error, initialFocus = false;

        protected override void OnHandleCreated(EventArgs e)
        {
            if (TxtBorder)
            {
                Height = 1;
                Dock = DockStyle.Bottom;
                BackColor = Color.Black;
            }
            else if (TxtTag)
            {
                AutoSize = true;
                Dock = DockStyle.None;
                Font = new Font("", 9F);
                Location = new Point(-2, 10);
                ForeColor = Color.Black;

                if (InitialFocus)
                {
                    Font = new Font("", 7F);
                    Location = new Point(-2, 0);
                }
            }
            else if (TxtError)
            {
                AutoSize = true;
                Dock = DockStyle.Right;
                Font = new Font("", 7F);
                Visible = false;
                ForeColor = Color.Red;
            }

            base.OnHandleCreated(e);
        }

        public void ChangeColorFocus(bool isFocused)
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

        public void ChangeFocus(bool isFocused)
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

        public bool TxtError
        {
            get
            {
                return this.txtError;
            }
            set
            {
                this.txtError = value;
            }
        }

        public bool Error
        {
            get
            {
                return error;
            }
            set
            {
                if (value)
                {
                    if (TxtBorder)
                        this.BackColor = Color.Red;
                    else if (TxtTag)
                        this.ForeColor = Color.Red;
                }
                else
                {
                    ChangeColorFocus(false);
                    ChangeFocus(true);
                }

                error = value;
            }
        }

        public bool InitialFocus
        {
            get
            {
                return this.initialFocus;
            }
            set
            {
                this.initialFocus = value;
            }
        }
    }
}
