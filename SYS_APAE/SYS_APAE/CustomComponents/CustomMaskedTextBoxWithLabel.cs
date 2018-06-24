﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomMaskedTextBoxWithLabel : Panel
    {
        private readonly CustomLabel TextBoxLabel = new CustomLabel(false, true);
        private readonly CustomMaskedTextBox CTextBox;

        public CustomMaskedTextBoxWithLabel()
        {
            this.CTextBox = new CustomMaskedTextBox(this);
            Controls.Add(this.CTextBox);
            Controls.Add(this.TextBoxLabel);
        }

        public void ChangeLabelFocus(bool isFocused)
        {
            if (this.CTextBox.Text == String.Empty)
                this.TextBoxLabel.changeFocus(isFocused);

            this.TextBoxLabel.changeColorFocus(isFocused);
        }

        public void TextBoxKeyDown(KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        public override void ResetText()
        {
            this.TextBoxLabel.changeFocus(false);

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
    }
}
