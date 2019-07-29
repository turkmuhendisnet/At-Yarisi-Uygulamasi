using System;
using System.Windows.Forms;
using System.Drawing;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int zaman = 0;      
        private void tmrAtYarisi_Tick(object sender, EventArgs e)
        {      
            Random rnd = new Random();
           // pcbAt1.Image = Properties.Resources.At_1;
           // pcbAt2.Image = Properties.Resources.At_2;
           // pcbAt3.Image = Properties.Resources.At_3;

            pcbAt1.Left += rnd.Next(1, 20);
            pcbAt2.Left += rnd.Next(1, 20);
            pcbAt3.Left += rnd.Next(1, 20);
            
            if (pcbAt1.Right >= pcbAt2.Right && pcbAt1.Right >= pcbAt3.Right) //at1 onde ise
            {
                if (pcbAt1.Right == pcbAt2.Right)
                {
                    lblYarisDurumu.Text = "1. at ve 2.at arasında eşitlik söz konusu ";
                }
                else if (pcbAt1.Right == pcbAt3.Right)
                {
                    lblYarisDurumu.Text = "1. at ve 3.at arasında eşitlik söz konusu ";
                }else
                    lblYarisDurumu.Text = "1. at Önde Gidiyor";
            }
            else if (pcbAt2.Right >= pcbAt1.Right && pcbAt2.Right >= pcbAt3.Right)  //at2 onde ise
            {
                if (pcbAt1.Right == pcbAt2.Right)
                {
                    lblYarisDurumu.Text = "1. at ve 2.at arasında eşitlik söz konusu ";
                }
                else if (pcbAt2.Right == pcbAt3.Right)
                {
                    lblYarisDurumu.Text = "2. at ve 3.at arasında eşitlik söz konusu ";
                }
                else
                    lblYarisDurumu.Text = "2. at Önde Gidiyor";
            }
            else if (pcbAt3.Right > pcbAt1.Right && pcbAt3.Right > pcbAt2.Right)
            {
                lblYarisDurumu.Text = "3. at Önde Gidiyor";
            }
             if (pcbAt1.Location.X >= 977)
            {
                YarisBitinceİslemler(pcbAt1.Tag);
                //MessageBox.Show(pcbAt1.Tag + "  kazandı...");               
                //tmrYarisSuresi.Stop();
                //pcbAt1.Image = null;
            }
            if (pcbAt2.Location.X >= 977)
            {
                YarisBitinceİslemler(pcbAt2.Tag);
               // MessageBox.Show(pcbAt2.Tag + "  kazandı...");                              
                //tmrAtYarisi.Stop();
                //tmrYarisSuresi.Stop();
                //pcbAt2.Image = null;
            }
            if (pcbAt3.Location.X >= 977)
            {
                YarisBitinceİslemler(pcbAt3.Tag);
               // MessageBox.Show(pcbAt3.Tag + "  kazandı...");
                //tmrAtYarisi.Stop();
                //tmrYarisSuresi.Stop();
                //pcbAt3.Image = null;
                //pcbAt2.Image = null;
                //pcbAt1.Image = null;
            }
        }
        void YarisBitinceİslemler(object Tag)
        {
            tmrAtYarisi.Stop();
            tmrYarisSuresi.Stop();
            MessageBox.Show(Tag + "  kazandı...");
            pcbAt3.Image = null;
            pcbAt2.Image = null;
            pcbAt1.Image = null;           
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrYarisSuresi.Start();
            tmrAtYarisi.Enabled = true;
            lblYarisDurumu.Text = " Yarış Başladı Sevgili Seyirciler";           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Bura sonradan yaptım
            pcbAt1.Image = Properties.Resources.At_1;
            pcbAt1.Location = new Point(12, 71);
            pcbAt2.Image = Properties.Resources.At_2;
            pcbAt2.Location = new Point(12, 187);
            pcbAt3.Image = Properties.Resources.At_3;
            pcbAt3.Location = new Point(12, 304);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms[0] == this)//Uygulamanin main form'u
            {
                //uygulamanin ana formunu kapatirsaniz uygulama kapanir, ana formu yeniden baslatmak uygulamayi yeniden baslatmak demektir.
                Application.Restart();
            }
        }       
        private void tmrYarisSuresi_Tick(object sender, EventArgs e)
        {
            zaman++;
            lblSaniye.Text = zaman.ToString();
            
        }
    }
}
