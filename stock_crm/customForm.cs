using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
{
    public class customForm : Form
    {
        public virtual void initcomponent(Panel panel)
        {
            init(panel);
        }

        public virtual void initcomponent(SplitContainer panel)
        {
            init(panel);
        }
        
        private void init(Panel panel)
        {
            panel.Location = new Point(this.ClientSize.Width / 2 - panel.Size.Width / 2, this.ClientSize.Height / 2 - panel.Size.Height / 2);
            panel.Anchor = AnchorStyles.None;
        }

        private void init(SplitContainer panel)
        {
            panel.Location = new Point(this.ClientSize.Width / 2 - panel.Size.Width / 2, this.ClientSize.Height / 2 - panel.Size.Height / 2);
            panel.Anchor = AnchorStyles.None;
        }

    }
}
