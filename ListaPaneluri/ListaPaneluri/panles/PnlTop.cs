using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPaneluri.panles
{
    public class PnlTop:Panel
    {
        public FrmHome frmHome;
        public CheckBox cbox;
        public PnlTop(FrmHome frmHome)
        {
            this.frmHome = frmHome;

            this.Location = new Point(175, 12);
            this.Size = new Size(450, 104);
            this.BackColor = Color.Blue;
            this.Name="PnlTop";

            this.cbox = new CheckBox();
            this.Controls.Add(this.cbox);
            this.cbox.Location = new Point(101, 24);

        }



    }
}
