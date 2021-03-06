﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCalculator
{
    public partial class Form1 : Form
    {
        private bool blockRecursion = false;
        private int trackValue;
        private bool blockRecursion1 = false;
        private int trackValue1;
        public int ChooseResult1, ChooseResult2;
        public static int MaxResult;
        public Form1()
        {
            InitializeComponent();
            if(ChooseResult2 >= ChooseResult1)
            {
                label3.Text = "Нажаль за даних \nумов ми не можемо \nнадати кредит";
                button1.Visible = false;
                
            }
            else
            {
                label3.Visible = true;
                button1.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (blockRecursion) return;

            trackValue = trackBar1.Value;

            if (trackValue % trackBar1.SmallChange != 0)
            {
                trackValue = (trackValue / trackBar1.SmallChange) * trackBar1.SmallChange;

                blockRecursion = true;

                trackBar1.Value = trackValue;

                blockRecursion = false;
                lbl_income.Text = trackBar1.Value.ToString();
                ChooseResult1 = trackBar1.Value;
                ChooseResult2 = trackBar2.Value;
                MaxResult = (ChooseResult1 * ChooseResult2) / 100;
                if (ChooseResult2 >= ChooseResult1)
                {
                    label3.Text = "Нажаль за даних умов ми не можемо надати кредит";
                    
                    button1.Visible = false;
                }
                else
                {
                    label3.Text = $"Макс. сума кредиту\n {MaxResult}";
                    
                    button1.Visible = true;
                }
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (blockRecursion1) return;

            trackValue1 = trackBar2.Value;

            if (trackValue1 % trackBar2.SmallChange != 0)
            {
                trackValue1 = (trackValue1 / trackBar2.SmallChange) * trackBar2.SmallChange;

                blockRecursion1 = true;

                trackBar2.Value = trackValue1;

                blockRecursion1 = false;
                lbl_spend.Text = trackBar2.Value.ToString();
                ChooseResult1 = trackBar1.Value;
                ChooseResult2 = trackBar2.Value;
                MaxResult = (ChooseResult1 * ChooseResult2) / 100;
                if (ChooseResult2 >= ChooseResult1)
                {
                    label3.Text = "Нажаль за даних умов \nми не можемо надати кредит";
                    
                    button1.Visible = false;
                }
                else
                {
                    label3.Text = $"Макс. сума кредиту\n {MaxResult}";
                    
                    button1.Visible = true;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_spend_Click(object sender, EventArgs e)
        {

        }
    }
}
