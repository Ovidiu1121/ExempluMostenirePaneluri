using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPaneluri.panles
{
    internal class PnlBottom:Panel
    {
        public FrmHome frmHome;

        public PnlBottom(FrmHome frmHome)
        {
            this.frmHome = frmHome;

            this.Location = new Point(175, 334);
            this.Size = new Size(450, 104);
            this.BackColor = Color.Red;
            this.Name="PnlBottom";

        }



    }
}
