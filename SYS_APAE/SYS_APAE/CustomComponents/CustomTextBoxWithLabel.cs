﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomTextBoxWithLabel : Panel
    {
        private CustomLabel TextBoxLabel = new CustomLabel(false, true);
        private CustomTextBox CTextBox;

        public CustomTextBoxWithLabel()
        {
            this.CTextBox = new CustomTextBox(this.TextBoxLabel, this);
            Controls.Add(this.CTextBox);
            Controls.Add(this.TextBoxLabel);
        }

        public void textBoxKeyDown(KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
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
            this.TextBoxLabel.changeFocus(false);

            base.ResetText();
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
    }
}
