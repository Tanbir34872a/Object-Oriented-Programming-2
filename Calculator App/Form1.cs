using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Lab_Exam_21_44394_1
{
    public partial class Form1 : Form
    {
        int flag = 0; //to determine +-x/
        bool opstate = false; // to determine if a operator is selected
        string butVal = "0";  
        bool dotFlag = false; //to determine if we used a dot or not to avoid multiple dots
        double scrVal = 0;
        double totVal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            butVal = "0";
            if (!opstate)
            {
                if (scr.Text != "0")
                {
                    scr.Text += "0";
                }
            }
            else 
            {
                scr.Text = butVal;
                opstate = false;
            }
            fullform.Text += butVal;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            butVal = "1";
            if (!opstate)
            {
                if (scr.Text == "0")
                {
                    scr.Text = butVal;
                }
                else { scr.Text += butVal; }
            }
            else
            {
                scr.Text = butVal;
                opstate = false;
            }
            fullform.Text += butVal;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            butVal = "2";
            if (!opstate)
            {
                if (scr.Text == "0")
                {
                    scr.Text = butVal;
                }
                else { scr.Text += butVal; }
            }
            else
            {
                scr.Text = butVal;
                opstate = false;
            }
            fullform.Text += butVal;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            butVal = "3";
            if (!opstate)
            {
                if (scr.Text == "0")
                {
                    scr.Text = butVal;
                }
                else { scr.Text += butVal; }
            }
            else
            {
                scr.Text = butVal;
                opstate = false;
            }
            fullform.Text += butVal;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            butVal = "4";
            if (!opstate)
            {
                if (scr.Text == "0")
                {
                    scr.Text = butVal;
                }
                else { scr.Text += butVal; }
            }
            else
            {
                scr.Text = butVal;
                opstate = false;
            }
            fullform.Text += butVal;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            butVal = "5";
            if (!opstate)
            {
                if (scr.Text == "0")
                {
                    scr.Text = butVal;
                }
                else { scr.Text += butVal; }
            }
            else
            {
                scr.Text = butVal;
                opstate = false;
            }
            fullform.Text += butVal;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            butVal = "6";
            if (!opstate)
            {
                if (scr.Text == "0")
                {
                    scr.Text = butVal;
                }
                else { scr.Text += butVal; }
            }
            else
            {
                scr.Text = butVal;
                opstate = false;
            }
            fullform.Text += butVal;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            butVal = "7";
            if (!opstate)
            {
                if (scr.Text == "0")
                {
                    scr.Text = butVal;
                }
                else { scr.Text += butVal; }
            }
            else
            {
                scr.Text = butVal;
                opstate = false;
            }
            fullform.Text += butVal;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            butVal = "8";
            if (!opstate)
            {
                if (scr.Text == "0")
                {
                    scr.Text = butVal;
                }
                else { scr.Text += butVal; }
            }
            else
            {
                scr.Text = butVal;
                opstate = false;
            }
            fullform.Text += butVal;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            butVal = "9";
            if (!opstate)
            {
                if (scr.Text == "0")
                {
                    scr.Text = butVal;
                }
                else { scr.Text += butVal; }
            }
            else
            {
                scr.Text = butVal;
                opstate = false;
            }
            fullform.Text += butVal;
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            butVal = ".";
            if (!dotFlag)
            {
                if (!opstate)
                {
                    if (scr.Text == "0")
                    {
                        scr.Text = "0.";
                    }
                    else { scr.Text += butVal; }
                }
                else
                {
                    scr.Text = "0.";
                    opstate = false;
                }
                fullform.Text += butVal;
            }
            dotFlag = true;
        }

        private void bplus_Click(object sender, EventArgs e)
        {
            scrVal = Convert.ToDouble(scr.Text);
            if (flag == 0) { totVal = scrVal; }
            if (flag == 1) { totVal += scrVal; }
            if (flag == 2) { totVal -= scrVal; }
            if (flag == 3) { totVal *= scrVal; }
            if (flag == 4) { totVal /= scrVal; }
            scr.Text = Convert.ToString(totVal);
            opstate = true;
            dotFlag = false;
            flag = 1;
            fullform.Text += "+";
        }

        private void bminus_Click(object sender, EventArgs e)
        {
            scrVal = Convert.ToDouble(scr.Text);
            if (flag == 0) { totVal = scrVal; }
            if (flag == 1) { totVal += scrVal; }
            if (flag == 2) { totVal -= scrVal; }
            if (flag == 3) { totVal *= scrVal; }
            if (flag == 4) { totVal /= scrVal; }
            scr.Text = Convert.ToString(totVal);
            opstate = true;
            dotFlag = false;
            flag = 2;
            fullform.Text += "-";
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            scrVal = Convert.ToDouble(scr.Text);
            if (flag == 0) { totVal = scrVal; }
            if (flag == 1) { totVal += scrVal; }
            if (flag == 2) { totVal -= scrVal; }
            if (flag == 3) { totVal *= scrVal; }
            if (flag == 4) { totVal /= scrVal; }
            scr.Text = Convert.ToString(totVal);
            opstate = true;
            flag = 3;
            dotFlag = false;
            fullform.Text += "X";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            scrVal = Convert.ToDouble(scr.Text);
            if (flag == 0) { totVal = scrVal; }
            if (flag == 1) { totVal += scrVal; }
            if (flag == 2) { totVal -= scrVal; }
            if (flag == 3) { totVal *= scrVal; }
            if (flag == 4) { totVal /= scrVal; }
            scr.Text = Convert.ToString(totVal);
            opstate = true;
            flag = 4;
            dotFlag = false;
            fullform.Text += "/";
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            scrVal = Convert.ToDouble(scr.Text);
            if (flag == 0) { totVal = scrVal; }
            if (flag == 1) { totVal += scrVal; }
            if (flag == 2) { totVal -= scrVal; }
            if (flag == 3) { totVal *= scrVal; }
            if (flag == 4) { totVal /= scrVal; }
            scr.Text = Convert.ToString(totVal);
            fullform.Text = scr.Text;
            opstate = true;
            flag = 0;
            dotFlag = false;
        }

        private void bC_Click(object sender, EventArgs e)
        {
            butVal = "0";
            totVal = 0.0;
            opstate = false;
            dotFlag= false;
            scr.Text = butVal;
            dotFlag = false;
            fullform.Text = butVal;
        }

        private void scr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
