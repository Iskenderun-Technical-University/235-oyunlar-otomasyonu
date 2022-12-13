using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖrdekOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public
            Random rnd = new Random();

        int sure = 20;
        int toplamtik = 0;
        int isabetlitik = 0;
            int puan = 0;




        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Dock = DockStyle.Fill;
            panel2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            timer1.Interval = 1000;
            timer1.Start();

            timer2.Start();

            if (radioButton1.Checked = true) { timer2.Interval = 800; }
            if (radioButton2.Checked = true) { timer2.Interval = 600; }
            if (radioButton3.Checked = true) { timer2.Interval = 450; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString("SÜRE:" + sure);
            if (sure == 0)
            {
                timer1.Stop(); timer2.Stop();

                panel2.Dock = DockStyle.Fill;
                panel2.Show();

                toplamtik += isabetlitik;

                lbltoplamtik.Text = Convert.ToString("TOPLAM TIKLAMA:" + toplamtik);
                lblisabetlitik.Text = Convert.ToString("İSABETLİ TIKLAMA:" + isabetlitik);
                lblpuan.Text = Convert.ToString("PUAN:" + puan);


            }
            sure--;


        }

        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ordek.Location = new Point(Convert.ToInt32(rnd.Next(10, 700)));


                Convert.ToInt32(rnd.Next(10,250));  

        }

        private void ordek_Click(object sender, EventArgs e)
        {
            isabetlitik++;
            puan += 5;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            toplamtik++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sure = 20;
            toplamtik = 0;
            isabetlitik = 0;
            puan = 0;

            radioButton1.Checked = true;
            panel2.Hide();
            panel1.Show();
            ordek.Location = new Point(350, 110);

        }
    }
    }

