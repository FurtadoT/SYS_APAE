﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomMaskedTextBox : MaskedTextBox
    {
        private readonly CustomLabel borderLabel = new CustomLabel(true);
        private CustomMaskedTextBoxWithLabel _parent;
        private string maskWhenFocus;

        private void InitializeComponent()
        {
            this.BorderStyle = BorderStyle.None;
            this.AutoSize = false;
            this.Controls.Add(borderLabel);
        }

        public CustomMaskedTextBox()
        {
            InitializeComponent();
        }

        public CustomMaskedTextBox(CustomMaskedTextBoxWithLabel _parent)
        {
            InitializeComponent();

            Dock = DockStyle.Bottom;
            this._parent = _parent;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            this.borderLabel.changeColorFocus(true);
            if (_parent != null) _parent.ChangeLabelFocus(true);

            this.Mask = this.MaskWhenFocus;

            base.OnGotFocus(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            _parent.TextBoxKeyDown(e);

            base.OnKeyDown(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.Mask = null;

            this.borderLabel.changeColorFocus(false);
            if (_parent != null) _parent.ChangeLabelFocus(false);

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
