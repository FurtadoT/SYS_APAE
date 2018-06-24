using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomMaskedTextBoxWithLabel : Panel
    {
        private readonly CustomLabel TextBoxLabel = new CustomLabel() { TxtTag = true };
        private CustomLabel TextBoxLabelError = new CustomLabel() { TxtError = true };
        private readonly CustomMaskedTextBox CTextBox;

        public CustomMaskedTextBoxWithLabel()
        {
            Controls.Add(this.TextBoxLabel);
            Controls.Add(this.TextBoxLabelError);
            this.CTextBox = new CustomMaskedTextBox(this);
            Controls.Add(this.CTextBox);
        }

        public void ChangeLabelFocus(bool isFocused)
        {
            this.TextBoxLabelError.Visible = false;
 
            if (this.CTextBox.Text == String.Empty)
                this.TextBoxLabel.ChangeFocus(isFocused);

            this.TextBoxLabel.ChangeColorFocus(isFocused);
        }

        public void TextBoxKeyDown(KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        public override void ResetText()
        {
            this.TextBoxLabel.ChangeFocus(false);

            base.ResetText();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            this.TextBoxLabel.Click += (sn, ev) => { this.CTextBox.Focus(); };
            this.TextBoxLabel.BringToFront();

            if (this.BackColor != Color.Transparent)
                this.CTextBox.BackColor = this.BackColor;

            Size = new Size(this.Size.Width, 35);

            if (this.Tag != null)
                this.TextBoxLabel.Text = this.Tag.ToString();

            base.OnHandleCreated(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            this.CTextBox.Focus();

            base.OnGotFocus(e);
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
            get
            {
                return this.CTextBox.MaskWhenFocus;
            }
            set
            {
                this.CTextBox.MaskWhenFocus = value;
            }
        }

        public string ErrorMessage
        {
            get
            {
                return this.TextBoxLabelError.Text;
            }
            set
            {
                this.TextBoxLabelError.Text = value;
                this.TextBoxLabelError.Visible = true;
                this.CTextBox.Error = true;
                this.TextBoxLabel.Error = true;
            }
        }

        public bool MaskCompleted
        {
            get
            {
                return this.CTextBox.MaskCompletedWithoutFocus;
            }
        }
    }
}
