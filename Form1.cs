using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5._38_YilanOyunu
{
    public partial class Form1 : Form
    {

        const Keys tusYukari = Keys.Up, tusSag = Keys.Right, tusAsagi = Keys.Down, tusSol = Keys.Left;
        int XNoktasi, YNoktasi, XMaxBirim = 50, XMinBirim = 0, YMaxBirim = 50, YMinBirim = 0;
        bool tusaBasildiMi = false;
        int birBirim = 11;
        string yon; //Yönler: ↑←→↓
        Point yem;
        List<Point> yilan = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            //Yılanı başlangıç noktasında üç bölmeli oluşturma
            yilan.Clear();
            yilan.Add(new Point(12, 20));
            yilan.Add(new Point(11, 20));
            yilan.Add(new Point(10, 20));

            //Değerleri sıfırlama
            XNoktasi = 12;
            YNoktasi = 20;

            yon = "→";

            yemOlusturma();
            yilaniCiz();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if(btnBaslat.Text == "Başlat")
            {
                btnBaslat.Text = "Durdur";
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                btnBaslat.Text = "Başlat";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Yılanın pozisyonunu belirleme
            if (yon == "↓")
                YNoktasi++;
            else if (yon == "↑")
                YNoktasi--;
            else if (yon == "←")
                XNoktasi--;
            else if (yon == "→")
                XNoktasi++;

            bool oyunDurumu = false;
            if (XNoktasi > XMaxBirim || XNoktasi < XMinBirim || YNoktasi > YMaxBirim ||
                YNoktasi < YMinBirim)
                oyunDurumu = true;

            if (yilan.Any(t => t.X == XNoktasi && t.Y == YNoktasi))
                oyunDurumu = true;

            if (oyunDurumu == true)
            {
                timer1.Enabled = false;
                MessageBox.Show("Oyun Bitti!");
                return;
            }

            yilan.Insert(0, new Point(XNoktasi, YNoktasi));
            yilan.RemoveAt(yilan.Count - 1);

            if (yem.X == XNoktasi * birBirim && yem.Y == YNoktasi * birBirim)
            {
                //Yemi yutma
                Point lastPoint = yilan[yilan.Count - 1];
                yilan.Add(new Point(lastPoint.X, lastPoint.Y));
                lYutulanYemSayisi.Text = (yilan.Count - 3).ToString();
                yemOlusturma();
            }

            yilaniCiz();
            tusaBasildiMi = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys basilanTus)
        {
            if (timer1.Enabled && tusaBasildiMi == false)
            {
                tusaBasildiMi = true;
                //Yön belirleme
                switch (basilanTus)
                {
                    case tusYukari:
                        if (yon != "↓")
                            yon = "↑";
                        break;
                    case tusAsagi:
                        if (yon != "↑")
                            yon = "↓";
                        break;
                    case tusSol:
                        if (yon != "→")
                            yon = "←";
                        break;
                    case tusSag:
                    default:
                        if (yon != "←")
                            yon = "→";
                        break;
                }
            }
            return base.ProcessCmdKey(ref msg, basilanTus);
        }

        private void yemOlusturma()
        {
            Random rastgele = new Random(DateTime.Now.TimeOfDay.Milliseconds);
            int x = 0, y = 0;
            bool bosYerVarMi = true;

            while (bosYerVarMi)
            {
                x = rastgele.Next(XMinBirim, XMaxBirim + 1) * birBirim;
                y = rastgele.Next(YMinBirim, YMaxBirim + 1) * birBirim;

                bosYerVarMi = yilan.Any(t => t.X == x && t.Y == y);
            }

            yem = new Point(x, y);
        }

        private void yilaniCiz()
        {
            pnlAlan.Refresh();
            Graphics g = this.pnlAlan.CreateGraphics();
            Pen kalem = new Pen(Color.Blue, 5);
            g.DrawRectangle(kalem, yem.X, yem.Y, 5, 5);
            foreach (Point item in yilan)
            {
                int x = item.X * birBirim;
                int y = item.Y * birBirim;

                g.DrawRectangle(kalem, x, y, 5, 5);
            }
            kalem.Dispose();
        }
    }
}
