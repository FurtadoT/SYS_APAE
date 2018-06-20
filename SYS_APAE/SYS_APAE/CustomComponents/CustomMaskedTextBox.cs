using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomMaskedTextBox : MaskedTextBox
    {
        private Label controlLabel;
        private string maskWhenFocus;

        public CustomMaskedTextBox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;
            Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
        }

        public CustomMaskedTextBox(Label label)
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;
            Dock = DockStyle.Bottom;
            Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
            this.controlLabel = label;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            if (this.controlLabel != null)
            {
                this.controlLabel.Click += (sn, ev) => { this.Focus(); };
            }

            base.OnHandleCreated(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            this.Mask = this.MaskWhenFocus;
            if (this.controlLabel != null)
            {
                this.controlLabel.Location = new Point(-2, 0);
                this.controlLabel.Font = new System.Drawing.Font("", 7F);
            }

            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.Mask = null;
            if (this.controlLabel != null)
                if (this.Text == String.Empty)
                {
                    this.controlLabel.Location = new Point(-2, 10);
                    this.controlLabel.Font = new System.Drawing.Font("", 9F);
                }

            base.OnLostFocus(e);
        }

        public string MaskWhenFocus
        {
            get
            {
                return this.maskWhenFocus;
            }
            set
            {
                this.maskWhenFocus = value;
            }
        }
    }
}
