using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGameForCollege
{
    public partial class Form1 : Form
    {
        public void end()
        {
            pbRoad1.Visible = false;
            pbRoad2.Visible = false;
            btnStart.Visible = false;
            pbPC.Visible = false;
            pbFinish.Visible = false;
            pbFinish.Visible = false;
            plFinish.Visible = false;
            pbPlayer.Visible = false;
            lblTrafficLights.Visible = false;
            pbTrafficLights.Visible = false;
            btnMove.Visible = false;
            btnMove.Visible = false;
            timerForMove.Enabled = false;
            timerForTraLie.Enabled = false;
            lblResult.Visible = true;
        }
        int i = 3;
        int k = 0;
        int color = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pbRoad1.Visible = true;
            pbRoad2.Visible = true;
            btnStart.Visible = false;
            pbPC.Visible = true;
            pbFinish.Visible = true;
            pbFinish.Visible = true;
            plFinish.Visible = true;
            pbPlayer.Visible = true;
            lblTrafficLights.Visible = true;
            timerForTraLie.Enabled = true;
            timerForMove.Enabled = true;
            pbTrafficLights.Visible = true;
            btnMove.Visible = true;
        }

        private void timerForTraLie_Tick(object sender, EventArgs e)
        {
            switch (k)
            {
                case 0:

                    lblTrafficLights.Text = "Приготовтесь " + i;
                    i--;
                    if (i == 0)
                    {
                        k = 2;
                    }
                    break;
                case 2:
                    timerForTraLie.Interval = 5000;
                    if (color == 1)
                    {
                        lblTrafficLights.Text = "Red";
                        lblTrafficLights.ForeColor = System.Drawing.Color.Red;
                        color += 1;
                    }
                    else
                    {
                        lblTrafficLights.Text = "Green";
                        lblTrafficLights.ForeColor = System.Drawing.Color.Green;
                        color = 1;
                    }

                    break;
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (color == 1)
            {
                pbPlayer.Left -= 100;
            }
            else
            {
                pbPlayer.Left += 6;
            }
        }

        private void timerForMove_Tick(object sender, EventArgs e)
        {
            if (color == 1)
            {
                pbPC.Left -= 3;
            }
            if (pbPlayer.Location.X <= plFinish.Location.X)
            {
                end();
                lblResult.Text = "Вы выиграли";
            }
            if (pbPC.Location.X <= plFinish.Location.X)
            {
                end();
                lblResult.Text = "Вы проиграли";
            }
        }
    }
}
