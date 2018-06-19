using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE.SYS_APAE.SYS_APAE.CustomComponents
{
    class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;
            Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
        }
    }
}
