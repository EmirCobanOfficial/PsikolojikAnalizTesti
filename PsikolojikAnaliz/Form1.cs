using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsikolojikAnaliz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru;
        int toplam = 0;

        private void button6_Click(object sender, EventArgs e)
        {
            soru++;
            button6.Text = "Sonraki";
            button6.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            if (soru == 1)
            {
                textBox1.Text = "Sevgilinizle ya da eşinizle mükemmel bir akşam size aşağıdakilerden hangisini çağrıştırıyor?";
                button1.Text = "bir rock konserine gitmek";
                button2.Text = "lunaparka gitmek";
                button3.Text = "Sinemaya gitmek";
                button4.Text = "Mum işiğinda romantik bir yemek";
                button5.Text = "Arabayla turlamak";
            }
            if (soru == 2)
            {
                textBox1.Text = "En sevdiğin müzik türü hangisidir?";
                button1.Text = "Alternatif";
                button2.Text = "Rock and roll";
                button3.Text = "Pop";
                button4.Text = "Soft Rock";
                button5.Text = "Klasik";
            }
            if (soru == 3)
            {
                textBox1.Text = "En çok hangi tür filmleri seversiniz?";
                button1.Text = "Korku";
                button2.Text = "Komedi";
                button3.Text = "Müzikal";
                button4.Text = "Romantik";
                button5.Text = "Belgesel";
            }
            if (soru == 4)
            {
                textBox1.Text = "Aşağıdaki mesleklerden birini seçmeniz gerekseydi hangisi olurdunuz?";
                button1.Text = "Barmen/Barmaid";
                button2.Text = "Polis";
                button3.Text = "Öğretmen";
                button4.Text = "Garson";
                button5.Text = "Futbolcu";
            }
            if (soru == 5)
            {
                textBox1.Text = "Bir saat boş vaktinizi değerlendirmek için hangi size daha uygun?";
                button1.Text = "TV izlemek";
                button2.Text = "internette gezinmek";
                button3.Text = "Uyumak";
                button4.Text = "Kitap Okumak";
                button5.Text = "Dışarıda çalışmak";
            }
            if (soru == 6)
            {
                textBox1.Text = "Aşağıdaki renklerden birini seçiniz.";
                button1.Text = "Sarı";
                button2.Text = "Kahverengi";
                button3.Text = "Mavi";
                button4.Text = "Kırmızı";
                button5.Text = "Beyaz";
            }
            if (soru == 7)
            {
                textBox1.Text = "Şu an önümüzde aşağıdaki yiyeceklerden hangisi olsa dayanamayıp götürürsünüz?";
                button1.Text = "Şusi";
                button2.Text = "Pizza";
                button3.Text = "Dondurma";
                button4.Text = "Makarna";
                button5.Text = "Salata";
            }
            if (soru == 8)
            {
                textBox1.Text = "En sevdiğiniz tatil, bayram ya da özel gün hangisi?";
                button1.Text = "23 Nisan Çocuk Bayramı";
                button2.Text = "Yılbaşı Tatili";
                button3.Text = "Ramazan Bayramı";
                button4.Text = "Sevgililer Günü";
                button5.Text = "Kurban Bayramı";
            }
            if (soru == 9)
            {
                textBox1.Text = "Şu an aşağıdakilerden hangisinde olmak isterdiniz";
                button1.Text = "Las Vegas'ta";
                button2.Text = "Hawaii'de";
                button3.Text = "Hollywood'da";
                button4.Text = "Paris'te";
                button5.Text = "İspanya'da";
            }
            if (soru == 10)
            {
                textBox1.Text = "Nasıl biriyle vakit geçirmekten hoşlanırsınız?";
                button1.Text = "Bir parti canavarıyla";
                button2.Text = "Güzel/Yakışıklı biriyle";
                button3.Text = "Komik biriyle";
                button4.Text = "Duygusal biriyle";
                button5.Text = "Akıllı biriyle";
            }
            if(soru == 11)
            {
                label1.Visible = true;
                label2.Visible = true;
                label2.Text = toplam.ToString();
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;

                if (toplam >= 10 && toplam <= 17)
                {
                    textBox1.Text = "Siz vahşi ve çılgın birisiniz. Eğleneyim derken uçuyorsunuz. Ama her zaman ne yaptığınızın farkındasınız, hayatınızın kontrolünü kaybetmiyorsunuz. İnsanlar olaylara sizin gibi bakmadığında bu sizi durdurmuyor.Tavsiye: Bu vahşi karakterinizle kendinizi ve etrafınızdakileri incitebilirsiniz. Dikkatli olun.";
                }
                if (toplam >= 18 && toplam <= 26)
                {
                    textBox1.Text = "Siz eğlenceli, arkadaş canlısı ve popülersiniz. Civil civil halinizle etrafa neşe saçıyorsunuz. Çoğu zaman ikili ilişkilerinizde uçuk kaçık davransanız da inandığınız değerlerden asla taviz vermiyorsunuz. Evlilik ve çocuk sahibi olmak sizin için önemli ama öncelikle yeterince tecrübe edinmek istiyorsunuz. Tavsiye: İnsanların aldığınız kararlarda sizi bu kadar etkilemelerine izin vermeyin.";
                }
                if (toplam >= 27 && toplam <= 34)
                {
                    textBox1.Text = "Öyle tatlısınız ki sizi sevmemek imkansız. Siz insanların asla kaybetmek istemeyeceği türden bir dostsunuz. Kimseyi incitmemek için kendinizi incittiğiniz bile oluyor. Siz genellikle olaylar karşısında olgun ve sakin bir tavır takınırsınız.Tavsiye: Herkes göründüğü gibi değildir, bunu unutmayın. Biraz kurnaz olun.";
                }
                if (toplam >= 35 && toplam <= 42)
                {
                    textBox1.Text = "Siz iflah olmaz bir romantiksiniz. Şarap, kırmızı güller, bunlar sizin yaşam tarzınız. Söz verirsiniz ve o sözü ne olursa olsun yerine getirirsiniz. Ailenize çok bağlısınız. Annenizi her haftasonu ararsınız, özel günleri asla unutmazsınız.Tavsiye: Fazla romantizmin sizi gerçeklerden uzaklaştırmasına izin vermeyin.";
                }
                if (toplam >= 43 && toplam <= 50)
                {
                    textBox1.Text = "Belirgin özelliğiniz hızlı ve doğru karar verebilmeniz. Her olay için kafanızda bir planınız vardır. Fiziksel ve zihinsel gücünüz çok fazla. Mantıklı, ılımlı ve yapıcı tavırlarınızla çoğu kişinin kendine örnek aldığı birisiniz.Tavsiye: Küçük gibi görünen bazı olayları gözardı etmeniz ileride büyük sorunlara yol açabilir.";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplam = toplam + 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplam = toplam + 2;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toplam = toplam + 3;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toplam = toplam + 4;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            toplam = toplam + 5;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled=false;
            button2.Enabled=false;
            button3.Enabled=false;
            button4.Enabled=false;
            button5.Enabled=false;
        }
    }
}
