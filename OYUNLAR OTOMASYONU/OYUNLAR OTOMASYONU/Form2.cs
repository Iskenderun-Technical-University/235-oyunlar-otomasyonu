using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYUNLAR_OTOMASYONU
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btna_Click(object sender, EventArgs e)
        {
            Btna.Enabled = false;
            Btnb.Enabled = false;
            Btnc.Enabled = false;
            Btnd.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = Btna.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }




        }



        int soruno = 0, dogru = 0, yanlis = 0;
        private void Btnb_Click(object sender, EventArgs e)
        {
            Btna.Enabled = false;
            Btnb.Enabled = false;
            Btnc.Enabled = false;
            Btnd.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = Btnb.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }

        }
        private void Btnc_Click(object sender, EventArgs e)
        {
            Btna.Enabled = false;
            Btnb.Enabled = false;
            Btnc.Enabled = false;
            Btnd.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = Btnc.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }
         private void Btnd_Click(object sender, EventArgs e)
        {
            Btna.Enabled = false;
            Btnb.Enabled = false;
            Btnc.Enabled = false;
            Btnd.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = Btnd.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            Btna.Enabled = true;
            Btnb.Enabled = true;
            Btnc.Enabled = true;
            Btnd.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            // sorular buradan geliyor
            soruno++;
            LblSoru.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç yılında ilan edilmiştir?";
                Btna.Text = "1923";
                Btnb.Text = "1929";
                Btnc.Text = "1920";
                Btnd.Text = "1930";
                label4.Text = "1923";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "İskenderun Teknik Üniversitesi Kaç Yılında Kurulmuştur?";
                Btna.Text = "2012";
                Btnb.Text = "2013";
                Btnc.Text = "2015";
                Btnd.Text = "2010";
                label4.Text = "2015";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Ortalama İnsan Ömrü Kaç Yıldır";
                Btna.Text = "73.5";
                Btnb.Text = "75";
                Btnc.Text = "72.3";
                Btnd.Text = "73.2";
                label4.Text = "73.2";

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Kız Kalesi hangi ilimizdedir";
                Btna.Text = "Hatay";
                Btnb.Text = "Mersin";
                Btnc.Text = "İzmir";
                Btnd.Text = "Ankara";
                label4.Text = "Mersin";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yerel seçimler kaç yılda bir yapılır?\r\n\r\n";
                Btna.Text = "5";
                Btnb.Text = "6";
                Btnc.Text = "2";
                Btnd.Text = "3";
                label4.Text = "5";
                BtnSonraki.Text = "SONUÇLAR";
            }
            if (soruno == 6)
            {
                Btna.Enabled = false;
                Btnb.Enabled = false;
                Btnc.Enabled = false;
                Btnd.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru:" + dogru + "\n" + "Yanlış" + yanlis);
            }
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}
