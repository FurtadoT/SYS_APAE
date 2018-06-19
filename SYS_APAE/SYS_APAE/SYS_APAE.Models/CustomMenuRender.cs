using System.Drawing;
using System.Windows.Forms;

namespace SYS_APAE.SYS_APAE.Models
{
    public class CustomMenuRender : ToolStripProfessionalRenderer
    {
        public CustomMenuRender() : base(new MyColors()) { }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Enabled)
                base.OnRenderMenuItemBackground(e);
        }
    }

    public class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemBorder
        {
            get { return Color.DarkGreen; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.LightGreen; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.LightGreen; }
        }
    }
}
