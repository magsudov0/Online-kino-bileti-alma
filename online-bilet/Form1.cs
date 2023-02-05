using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_bilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int seans1qiymet = 0;
        int seans2 = 0;
        int seans2qiymet = 0;
        int seans3 = 0;
        int seans3qiymet = 0;
        int popkorn = 0;
        int qiymet = 0;
        int cipsi = 0;
        int cipsiqiymet = 0;
        int araxis = 0;
        int araxisqiymet = 0;
        int kola = 0;
        int kolaqiymet = 0;
        int fanta = 0;
        int fantaqiymet = 0;
        int su = 0;
        int suqiymet = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            seans1++;
            seans1qiymet = seans1qiymet + 4;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1qiymet.ToString();

            if (seans1 == 50)
            {
                button1.Enabled = false;
            }
            if (seans1 >= 0)
            {
                button2.Enabled = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seans1qiymet = seans1qiymet - 4;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1qiymet.ToString();
            if (seans1 == 0)
            {
                button2.Enabled = false;
            }
            if (seans1 <= 50)
            {
                button1.Enabled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2++;
            seans2qiymet = seans2qiymet + 6;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2qiymet.ToString();

            if (seans2 == 50)
            {
                button3.Enabled = false;
            }
            if (seans2 >= 0)
            {
                button4.Enabled = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2qiymet = seans2qiymet - 6;
            textBox3.Text = seans2.ToString();
            textBox4.Text = seans2qiymet.ToString();
            if (seans2 == 0)
            {
                button4.Enabled = false;
            }
            if (seans2 <= 50)
            {
                button3.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seans3++;
            seans3qiymet = seans3qiymet + 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3qiymet.ToString();

            if (seans3 == 50)
            {
                button5.Enabled = false;
            }
            if (seans3 >= 0)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seans3--;
            seans3qiymet = seans3qiymet - 8;
            textBox5.Text = seans3.ToString();
            textBox6.Text = seans3qiymet.ToString();
            if (seans3 == 0)
            {
                button6.Enabled = false;
            }
            if (seans3 <= 50)
            {
                button5.Enabled = true;
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            popkorn++;
            qiymet = qiymet + 3;
            textBox8.Text = popkorn.ToString();
            textBox7.Text = qiymet.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            popkorn--;
            qiymet = qiymet - 3;
            textBox8.Text = popkorn.ToString();
            textBox7.Text = qiymet.ToString();



        }

        private void button10_Click(object sender, EventArgs e)
        {
            cipsi++;
            cipsiqiymet = cipsiqiymet + 2;
            textBox10.Text = cipsi.ToString();
            textBox9.Text = cipsiqiymet.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cipsi--;
            cipsiqiymet = cipsiqiymet - 2;
            textBox10.Text = cipsi.ToString();
            textBox9.Text = cipsiqiymet.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            araxis++;
            araxisqiymet = araxisqiymet + 4;
            textBox11.Text = araxis.ToString();
            textBox12.Text = araxisqiymet.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            araxis--;
            araxisqiymet = araxisqiymet - 4;
            textBox11.Text = araxis.ToString();
            textBox12.Text = araxisqiymet.ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            kola++;
            kolaqiymet = kolaqiymet + 1;
            textBox13.Text = kola.ToString();
            textBox14.Text = kolaqiymet.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kola--;
            kolaqiymet = kolaqiymet - 1;
            textBox13.Text = kola.ToString();
            textBox14.Text = kolaqiymet.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            fanta++;
            fantaqiymet = fantaqiymet + 1;
            textBox15.Text = fanta.ToString();
            textBox16.Text = fantaqiymet.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            fanta--;
            fantaqiymet = fantaqiymet - 1;
            textBox15.Text = fanta.ToString();
            textBox16.Text = fantaqiymet.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            su++;
            suqiymet = suqiymet + 1;
            textBox17.Text = su.ToString();
            textBox18.Text = suqiymet.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            su--;
            suqiymet = suqiymet - 1;
            textBox17.Text = su.ToString();
            textBox18.Text = suqiymet.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int umumiizleyici, umumiborc;
            umumiizleyici = seans1 + seans2 + seans3;
            label13.Text = umumiizleyici.ToString();
            umumiborc = seans1qiymet + seans2qiymet + seans3qiymet + qiymet + kolaqiymet + araxisqiymet + cipsiqiymet + fantaqiymet + suqiymet;
            label14.Text = umumiborc.ToString();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            label13.Text = "00";
            label14.Text = "00";
            Controls.OfType<TextBox>().ToList().ForEach(c => c.Text = "");
            panel1.Controls.OfType<TextBox>().ToList().ForEach(c => c.Text = "");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
