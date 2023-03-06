using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPaneluri.panles
{
    internal class PnlFill:Panel
    {
        public FrmHome frmHome;

        public PnlFill(FrmHome frmHome)
        {
            this.frmHome = frmHome;

            this.Location = new Point(175, 122);
            this.Size = new Size(450, 206);
            this.BackColor = Color.Green;
            this.Name="PnlFill";

        }

    }
}
