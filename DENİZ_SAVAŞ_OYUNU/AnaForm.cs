
using System;
using System.Windows.Forms;
using Deniz.Library.Concrete;
using Deniz.Library.Enum;


//Öğrenci Adı-Soyadı:İnci KABAK
//Öğrenci Numarası:B211200061




namespace DENİZ_SAVAŞ_OYUNU
{
    public partial class AnaForm : Form
    {

        private readonly Oyun _oyun;
        private Panel savaşgemisiPanel;


        public AnaForm()
        {
            InitializeComponent();

            _oyun=new Oyun(savaşgemisiPanel,savasAlanıPanel);
            _oyun.GeçenSüreDeğişti += Oyun_GeçenSüreDeğişti;
        }

       

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.SavasGemisiniHareketEttir(Yön.Sağa);
                    break;
                case Keys.Left:
                    _oyun.SavasGemisiniHareketEttir(Yön.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
            }
            
        }

        private void Oyun_GeçenSüreDeğişti(object sender, EventArgs e)
        {
            // süreLabel.Text = _oyun.GeçenSüre.ToString(@"m\:ss");
            süreLabel.Text = $"{_oyun.GeçenSüre.Minutes}:{_oyun.GeçenSüre.Seconds.ToString("D2")}";


        }
    }
}
