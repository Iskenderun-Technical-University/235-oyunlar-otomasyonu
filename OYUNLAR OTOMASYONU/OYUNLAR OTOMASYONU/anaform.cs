using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zar_oyunu
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            
        }
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int zar1, zar2;
            Random rnd = new Random();
            zar1 = rnd.Next(0, 6);
            zar2 = rnd.Next(0, 6);
            pictureBox1.Image = ımageList1.Images[zar1];
            pictureBox2.Image = ımageList1.Images[zar2];
            sayac++;
            if (sayac == 30)
            {
                timer1.Stop();
                sayac = 0;
                button1.Enabled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Azure;    
        }
    }
}
