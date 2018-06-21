using System;
using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE_CUSTOM_COMPONENTS.CustomComponents
{
    class CustomTextBox : TextBox
    {
        private CustomLabel controlLabel, borderLabel = new CustomLabel(true);
        private CustomTextBoxWithLabel _parent;

        public CustomTextBox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;
            Controls.Add(borderLabel);
        }

        public CustomTextBox(CustomLabel label, CustomTextBoxWithLabel _parent)
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

        protected override void OnKeyDown(KeyEventArgs e)
        {
            _parent.textBoxKeyDown(e);

            base.OnKeyDown(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            if (this.controlLabel != null)
            {
                this.controlLabel.changeFocus(true);

                this.controlLabel.changeColorFocus(true);
                this.borderLabel.changeColorFocus(true);
            }

            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (this.controlLabel != null)
            {
                if (this.Text == String.Empty)
                    this.controlLabel.changeFocus(false);

                this.controlLabel.changeColorFocus(false);
                this.borderLabel.changeColorFocus(false);
            }

            base.OnLostFocus(e);
        }
    }
}
