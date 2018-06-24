﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomTextBox : TextBox
    {
        private CustomLabel borderLabel = new CustomLabel(true);
        private CustomTextBoxWithLabel _parent;

        private void InitializeComponent()
        {
            this.BorderStyle = BorderStyle.None;
            this.AutoSize = false;
            this.Controls.Add(borderLabel);
        }

        public CustomTextBox()
        {
            InitializeComponent();
        }

        public CustomTextBox(CustomTextBoxWithLabel _parent)
        {
            InitializeComponent();
            Dock = DockStyle.Bottom;
            this._parent = _parent;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            if (this.ReadOnly)
            {
                this.Controls.Remove(borderLabel);
                this.Enabled = false;
            }
            base.OnHandleCreated(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (_parent != null) _parent.TextBoxKeyDown(e);

            base.OnKeyDown(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            if (_parent != null) _parent.ChangeLabelFocus(true);
            this.borderLabel.changeColorFocus(true);

            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (_parent != null) _parent.ChangeLabelFocus(false);
            this.borderLabel.changeColorFocus(false);

            base.OnLostFocus(e);
        }
    }
}
