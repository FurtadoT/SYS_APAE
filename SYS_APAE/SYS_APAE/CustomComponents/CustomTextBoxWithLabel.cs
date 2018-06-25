using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomTextBoxWithLabel : Panel
    {
        private CustomLabel TextBoxLabel = new CustomLabel() { TxtTag = true };
        private CustomLabel TextBoxLabelError = new CustomLabel() { TxtError = true };
        private CustomTextBox CTextBox;

        public CustomTextBoxWithLabel()
        {
            Controls.Add(this.TextBoxLabel);
            Controls.Add(this.TextBoxLabelError);
            this.CTextBox = new CustomTextBox(this);
            Controls.Add(this.CTextBox);
        }

        public void TextBoxKeyDown(KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        public void TextBoxKeyUp(KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

        public void ChangeLabelFocus(bool isFocused)
        {
            this.TextBoxLabelError.Visible = false;

            if (this.CTextBox.Text == String.Empty)
                this.TextBoxLabel.ChangeFocus(isFocused);

            this.TextBoxLabel.ChangeColorFocus(isFocused);
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

        public override void ResetText()
        {
            this.TextBoxLabel.ChangeFocus(false);

            base.ResetText();
        }

        public bool ReadOnly
        {
            get
            {
                return this.CTextBox.ReadOnly;
            }
            set
            {
                this.CTextBox.ReadOnly = value;
            }
        }

        public override string Text
        {
            get
            {
                return this.CTextBox.Text;
            }
            set
            {
                this.TextBoxLabel.InitialFocus = true;
                this.CTextBox.Text = value;
            }
        }

        public char PasswordChar
        {
            get
            {
                return this.CTextBox.PasswordChar;
            }
            set
            {
                this.CTextBox.PasswordChar = value;
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
                if (value != String.Empty)
                {
                    this.TextBoxLabelError.Visible = true;
                    this.CTextBox.Error = true;
                    this.TextBoxLabel.Error = true;
                }
                else
                {
                    this.TextBoxLabelError.Visible = false;
                    this.CTextBox.Error = false;
                    this.TextBoxLabel.Error = false;
                }
            }
        }
    }
}
