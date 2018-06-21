using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomMaskedTextBox : MaskedTextBox
    {
        private CustomLabel controlLabel, borderLabel = new CustomLabel(true);
        private CustomMaskedTextBoxWithLabel _parent;
        private string maskWhenFocus;

        public CustomMaskedTextBox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;
            Controls.Add(borderLabel);
        }

        public CustomMaskedTextBox(CustomLabel label, CustomMaskedTextBoxWithLabel _parent)
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;
            Dock = DockStyle.Bottom;
            Controls.Add(borderLabel);
            this.controlLabel = label;
            this._parent = _parent;
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
                this.controlLabel.changeFocus(true);
                this.borderLabel.changeFocus(true);
            }

            base.OnGotFocus(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            _parent.textBoxKeyDown(e);

            base.OnKeyDown(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.Mask = null;
            if (this.controlLabel != null)
                if (this.Text == String.Empty)
                {
                    this.controlLabel.changeFocus(false);
                    this.controlLabel.changeFocus(false);
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
