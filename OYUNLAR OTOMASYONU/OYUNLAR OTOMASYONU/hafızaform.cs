using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafızaOyunuGP
{
    public partial class hafızaform : Form
    {
        List<string> icons = new List<string>()
        {
            "!",",","b,","k","v","w","z","N", // ikonlarımızı burada belirledik.Buttonların üzerinde gözükecek olan ikonlar.
            "!",",","b,","k","v","w","z","N"
        };
        Random rnd = new Random(); // random sınıfını kullanarak nesne ürettik.
        int randomindex;
        Timer t=new Timer(); // kartların arka yüzünü dönmeden önce göreceğimiz süreyi belirleyecek timerı tanımladık.
        Timer t2 = new Timer(); // seçilen buttonların ters yüzüne tekrar döneceği süreyi tanımladık.
        Button bir, iki;

        public hafızaform()
        {
            InitializeComponent();
            t.Tick += T_Tick; // timerin tick komutu kullanılarak süreler belirlendi.
            t.Start();
            t.Interval = 3000;
            show();
            t2.Tick += T2_Tick;
        }

        private void T2_Tick(object sender, EventArgs e)
        {
            t2.Stop();
            bir.ForeColor = bir.BackColor;
            iki.ForeColor = iki.BackColor;
            bir = null;
            iki = null;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            t.Stop();
            foreach (Button item in Controls)
            {
                item.ForeColor = item.BackColor;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void show()
        {
            Button btn;
            foreach (Button item in Controls)
            {
                btn = item as Button;
                randomindex = rnd.Next(icons.Count); // ikonların sayısı kadar rastgele buttonların hepsine şekiller dagıtıldı.
                btn.Text = icons[randomindex]; // buttonların textine de rastgele dagılmış ikonlar yerleştirildi.
                btn.ForeColor = Color.Black;
                icons.RemoveAt(randomindex); // aynı ikonlar fazla kez tekrar etmemesi için removeat komutu kullanıldı.

            }
        }
        int sayac = 0;
        private void Buton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (bir == null)
            {
               bir = btn;
               bir.ForeColor= Color.Black;
                return;
            }
            iki = btn;
            iki.ForeColor=Color.Black;
            if(bir.Text == iki.Text) // seçilen kartlar aynı gelirse arka plan renkleri ayarlandı ve tekrar ters dönmemeleri sağlandı.
            {
                bir.ForeColor= Color.Black;
                iki.ForeColor= Color.Black;
                bir = null; // buttonlar bu işlemden sonra tekrar kullanılması için null atandı.
                iki = null;
                sayac++;
                if (sayac == 8) // toplam 8 çift bulunduktan sonra oyunun sonlanması için close komutu kullanıldı.
                {
                    MessageBox.Show("Oyun Bitti.");
                    Close();
                }
            }
            else
            {
                t2.Start(); // eğer ki seçilen iki kart aynı değilse 1 saniye aradan sonra ters dönmeleri için gerekli süre tanımlandı.
                t2.Interval = 1000;
            }
        }
    }
}
