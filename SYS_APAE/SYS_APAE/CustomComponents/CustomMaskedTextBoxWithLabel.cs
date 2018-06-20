using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomMaskedTextBoxWithLabel : Panel
    {
        private Label TextBoxLabel = new Label()
        {
            AutoSize = true,
            Dock = DockStyle.None,
            Font = new System.Drawing.Font("", 9F),
            Location = new Point(-2, 10),
        };

        private CustomMaskedTextBox CTextBox;

        public CustomMaskedTextBoxWithLabel()
        {
            this.CTextBox = new CustomMaskedTextBox(this.TextBoxLabel);
            Controls.Add(this.CTextBox);
            Controls.Add(this.TextBoxLabel);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            this.TextBoxLabel.BringToFront();

            Size = new Size(this.Size.Width, 35);

            if (this.Tag != null)
                this.TextBoxLabel.Text = this.Tag.ToString();

            base.OnHandleCreated(e);
        }

        public override string Text
        {
            get
            {
                return this.CTextBox.Text;
            }
            set
            {
                this.CTextBox.Text = value;
            }
        }

        public string Mask
        {
            set
            {
                this.CTextBox.MaskWhenFocus = value;
            }
        }
    }
}
