using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btnb_Click(object sender, EventArgs e)
        {
            Btna.Enabled = false;
            Btnb.Enabled = false;
            Btnc.Enabled = false;
            Btnd.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text=Btnb.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlýs.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }
        int soruno = 0, dogru = 0, yanlis = 0;
    

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
                LblYanlýs.Text = yanlis.ToString();
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
                LblYanlýs.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
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



            soruno++;
            LblSoru.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç yýlýnda ilan edilmiþtir?";
                Btna.Text = "1923";
                Btnb.Text = "1929";
                Btnc.Text = "1920";
                Btnd.Text = "1930";
                label4.Text = "1923";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Ýskenderun Teknik Üniversitesi Kaç Yýlýnda Kurulmuþtur?";
                Btna.Text = "2012";
                Btnb.Text = "2013";
                Btnc.Text = "2015";
                Btnd.Text = "2010";
                label4.Text = "2015";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Ortalama Ýnsan Ömrü Kaç Yýldýr";
                Btna.Text = "73.5";
                Btnb.Text = "75";
                Btnc.Text = "72.3";
                Btnd.Text = "73.2";
                label4.Text = "73.2";

            }
            if(soruno == 4)
            {
                richTextBox1.Text = "Kýz Kalesi hangi ilimizdedir";
                Btna.Text = "Hatay";
                Btnb.Text = "Mersin";
                Btnc.Text = "Ýzmir";
                Btnd.Text = "Ankara";
                label4.Text = "Mersin";
            }
            if(soruno==5)
            {
                richTextBox1.Text = "Yerel seçimler kaç yýlda bir yapýlýr?\r\n\r\n";
                Btna.Text = "5";
                Btnb.Text = "6";
                Btnc.Text = "2";
                Btnd.Text = "3";
                label4.Text = "5";
                BtnSonraki.Text = "SONUÇLAR";
            }
            if(soruno==6)
            {
                Btna.Enabled = false;
                Btnb.Enabled = false;
                Btnc.Enabled = false;
                Btnd.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doðru:" + dogru + "\n" + "Yanlýþ" + yanlis);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                LblDogru.Text=dogru.ToString();
                pictureBox1.Visible=true;   
            }
            else
            {
                yanlis++;
                LblYanlýs.Text = yanlis.ToString();
                pictureBox2.Visible=true;   

            }
        }

   
    }
}