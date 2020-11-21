using System;
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
    public partial class Form2 : Form
    {
        int toCredit = 0;
        Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                toCredit = Convert.ToInt32(textBox1.Text);
                if (toCredit <= Form1.MaxResult && toCredit >= 1000)
                {
                    MessageBox.Show($"Кредит оформлено на суму {toCredit} грн.");
                    this.Close();
                }
                else if (toCredit < 1000 && toCredit >= 0)
                {
                    //MessageBox.Show($"Завелика сума для кредиту.");
                    MessageBox.Show($"Замала сума для кредиту.");
                }
                else if (toCredit > Form1.MaxResult)
                {
                    MessageBox.Show($"Завелика сума для кредиту.");
                }
                else if (toCredit < 0)
                {
                    MessageBox.Show("Число має бути більше нуля.");
                }
                else if (Convert.ToString(toCredit) == "VNTU")
                {
                    MessageBox.Show("Ми не обслуговуємо сміття!");
                }
            }
            catch(FormatException)
            {
                if (Convert.ToString(toCredit) != "VNTU")
                MessageBox.Show("Введіть ціле число!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Завелике число.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
