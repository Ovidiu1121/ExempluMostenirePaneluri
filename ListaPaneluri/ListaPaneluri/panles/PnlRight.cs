using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPaneluri.panles
{
    internal class PnlRight:Panel
    {
        public FrmHome frmHome;

        public PnlRight(FrmHome frmHome)
        {
            this.frmHome = frmHome;

            this.Location = new Point(631, 12);
            this.Size = new Size(157, 426);
            this.BackColor = Color.Orange;
            this.Name="PnlRight";


        }



    }
}
