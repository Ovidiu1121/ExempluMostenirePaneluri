using ListaPaneluri.panles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPaneluri
{
    public partial class FrmHome : Form
    {

        private List<Panel> panels = new List<Panel>();
        public FrmHome()
        {
            InitializeComponent();

            Button btnTop=new Button();
            Button btnBottom=new Button();
            Button btnLeft=new Button();
            Button btnRight=new Button();
            Button btnFill=new Button();

            this.Controls.Add(btnFill);
            this.Controls.Add(btnLeft);
            this.Controls.Add(btnRight);
            this.Controls.Add(btnTop);
            this.Controls.Add(btnBottom);

          

            btnBottom.Text="bottom";
            btnBottom.Location = new Point(312, 409);
            btnBottom.Click+=new EventHandler(this.bottom_Click);

            btnFill.Text="fill";
            btnFill.Location = new Point(412, 409);
            btnFill.Click+=new EventHandler(this.fill_Click);

            btnLeft.Text="left";
            btnLeft.Location = new Point(12, 409);
            btnLeft.Click+=new EventHandler(this.left_Click);

            btnRight.Text="right";
            btnRight.Location = new Point(112, 409);
            btnRight.Click+=new EventHandler(this.right_Click);

            btnTop.Text="top";
            btnTop.Location = new Point(212, 409);
            btnTop.Click+=new EventHandler(this.top_Click);

            Panel top = new PnlTop(this);
            Panel left = new PnlLeft(this);
            Panel right = new PnlRight(this);
            Panel fill = new PnlFill(this);
            Panel bottom = new PnlBottom(this);

            this.panels.Add(top);
            this.panels.Add(bottom);
            this.panels.Add(right);
            this.panels.Add(left);
            this.panels.Add(fill);




        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void top_Click(object sender, EventArgs e)
        {
            togglePanel("PnlTop");
        }

        private void bottom_Click(object sender, EventArgs e)
        {
            togglePanel("PnlBottom");
        }

        private void left_Click(object sender, EventArgs e)
        {
            togglePanel("PnlLeft");
        }

        private void right_Click(object sender, EventArgs e)
        {
            togglePanel("PnlRight");
        }

        private void fill_Click(object sender, EventArgs e)
        {
            togglePanel("PnlFill");
        }

        //functie ce primeste ca parametru numele la panel si returneaza panelul de masi sus

        private Panel returnPanelByName(string name)
        {
            for (int i = 0; i<this.panels.Count; i++)
            {
                if (panels[i].Name.Equals(name))
                {
                    return panels[i];
                }
            }

            return null;
        }

        private void togglePanel(String name)
        {

            Panel panel = this.returnPanelByName(name);
            if (this.Controls.Contains(panel))
            {

                this.Controls.Remove(panel);
            }
            else
            {
                this.Controls.Add(panel);
            }
        }



    }
}
