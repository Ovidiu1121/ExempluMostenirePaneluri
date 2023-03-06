using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPaneluri.panles
{
    public class PnlLeft:Panel
    {
        public FrmHome frmHome;

        public PnlLeft(FrmHome frmHome)
        {
            this.frmHome = frmHome;

            this.Location = new Point(12, 12);
            this.Size = new Size(157, 426);
            this.BackColor = Color.Yellow;
            this.Name="PnlLeft";

        }



    }
}
