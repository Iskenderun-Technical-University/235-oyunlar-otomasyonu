using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zar_oyunu;
using flappy_bird;
using HafızaOyunuGP;
 

namespace OYUNLAR_OTOMASYONU
{
    public partial class ana : Form
    {
        
        public ana()
        {
            InitializeComponent();
        }
      //  kuş oyunumuzun bulunduğu projedeki formu getiriyor
        private void button1_Click(object sender, EventArgs e)
        {
            flappy_bird.ANAFLAPPY AF=new flappy_bird.ANAFLAPPY();
            AF.Show();  
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //zar oyunumuzun bulunduğu projedeki formu getiriyor
        private void btn2_Click(object sender, EventArgs e)
        {

            zar_oyunu.anaform ZF=new zar_oyunu.anaform();   


            ZF.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
           
            


        }
        //exit butonumuz
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //githuba bağlantı butonumuz
        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Iskenderun-Technical-University/235-oyunlar-otomasyonu");
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //hafıza oyunun kodunu ana kaynagından getiriyoruz
        private void button4_Click(object sender, EventArgs e)
        {
            HafızaOyunuGP.hafızaform hf=new HafızaOyunuGP.hafızaform();
            hf.Show();

        }
    }
}
