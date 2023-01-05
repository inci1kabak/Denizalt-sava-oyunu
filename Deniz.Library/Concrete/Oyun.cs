using Deniz.Library.Enum;
using Deniz.Library.İnterface;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;






//Öğrenci Adı-Soyadı:İnci KABAK
//Öğrenci Numarası:B211200061




namespace Deniz.Library.Concrete
{
    public class Oyun : IOyun
    {
        #region Alanlar

        private readonly Timer _geçenSüreTimer = new Timer { Interval = 1000 };
        private readonly Timer _hareketTimer = new Timer { Interval = 100 };
        private readonly Timer _denizaltıOluşturmaTimer = new Timer { Interval = 2000 };
        private TimeSpan _geçenSüre;
        private readonly Panel _savaşgemisiPanel;
        private readonly Panel _savaşAlanıPanel;
        private savaşgemisi _savaşgemisi;
        private readonly List<mermi> _mermiler = new List<mermi>();
        private readonly List<denizaltı> _denizaltılar = new List<denizaltı>();
        #endregion


        #region Olaylar
        public event EventHandler GeçenSüreDeğişti;
        #endregion

        #region Özellikler
        public bool DevamEdiyorMu { get; private set; }

        public TimeSpan GeçenSüre
        {
            get => _geçenSüre;
            private set
            {
                _geçenSüre = value;

                GeçenSüreDeğişti?.Invoke(this, EventArgs.Empty);
            }
        }





        #endregion


        #region Metotlar
        public Oyun(Panel savaşgemisiPanel, Panel savaşAlanıPanel)
        {
            _savaşgemisiPanel = savaşgemisiPanel;
            _savaşAlanıPanel = savaşAlanıPanel;

            _geçenSüreTimer.Tick += GeçenSüreTimer_Tick;
            _hareketTimer.Tick += HareketTimer_Tick;
            _denizaltıOluşturmaTimer.Tick += denizaltıOluştumaTimer_Tick;
        }

        private void GeçenSüreTimer_Tick(object sender, EventArgs e)
        {
            GeçenSüre += TimeSpan.FromSeconds(1);
        }

        private void HareketTimer_Tick(object sender, EventArgs e)
        {
            mermileriHareketEttir();
            DenizaltılarıHareketEttir();
            VurulanDenizaltılarıCikar();
        }

        private void VurulanDenizaltılarıCikar()
        {
            for (var i = _denizaltılar.Count - 1; i >= 0; i--)
            {
                var denizaltı = _denizaltılar[i];

                var vuranmermi = denizaltı.VurulduMu(_mermiler);
                if (vuranmermi is null) continue;

                _denizaltılar.Remove(denizaltı);
                _mermiler.Remove(vuranmermi);
                _savaşAlanıPanel.Controls.Remove(denizaltı);
                _savaşAlanıPanel.Controls.Remove(vuranmermi);

            }

        }


        private void DenizaltılarıHareketEttir()
        {
            foreach (var denizaltı in _denizaltılar)
            {
                var carptıMı=denizaltı.HareketEttir(Yön.Aşağı);
                if (carptıMı) continue;

                Bitir();
                break;
            }
        }

        private void denizaltıOluştumaTimer_Tick(object sender,EventArgs e)
        {
            DenizaltıOluştur();
        }


        private void mermileriHareketEttir()
        {
            for (int i = _mermiler.Count - 1; i >= 0; i--)
            {
                var mermi =_mermiler[i];
                var carptıMi = mermi.HareketEttir(Yön.Yukari);
                if(carptıMi)
                {
                    _mermiler.Remove(mermi);
                    _savaşAlanıPanel.Controls.Remove(mermi);
                }
                

            }
        }




        public void Baslat()
        {
            if (DevamEdiyorMu) return;

            DevamEdiyorMu = true;


            ZamanlayicilariBaşlat();

            //SavaşgemisiOluştur();
            DenizaltıOluştur();
        }

        private void DenizaltıOluştur()
        {
            var denizaltı = new denizaltı(_savaşAlanıPanel.Size);
            _denizaltılar.Add(denizaltı);
            _savaşAlanıPanel.Controls.Add(denizaltı);
        }

        private void ZamanlayicilariBaşlat()
        {
         
            _geçenSüreTimer.Start();
            _hareketTimer.Start();
            _denizaltıOluşturmaTimer.Start();
        }



        /*
        private void SavaşgemisiOluştur()
        {
            _savaşgemisi = new savaşgemisi(_savaşgemisiPanel.Width, _savaşgemisiPanel.Size);
            
             _savaşgemisiPanel.Controls.Add(_savaşgemisi);
            
        }

        */





        private void Bitir()
        {
            if (!DevamEdiyorMu) return;

            DevamEdiyorMu = false;
            ZamanlayicilariDurdur();
        }

        private void ZamanlayicilariDurdur()
        {
            _geçenSüreTimer.Stop();
            _hareketTimer.Stop();
            _denizaltıOluşturmaTimer.Stop();
        }





        public void AtesEt()
        {
            if (!DevamEdiyorMu) return;

            var mermi = new mermi(_savaşAlanıPanel.Size, _savaşgemisi.Center);
            _savaşAlanıPanel.Controls.Add(mermi);
            _mermiler.Add(mermi);
            //mermi.HareketEttir(Yön.Yukari);
        }

        public void SavasGemisiniHareketEttir(Yön yön)
        {
            if (!DevamEdiyorMu) return;
            _savaşgemisi.HareketEttir(yön);
        }

        
        
        #endregion
    }
}
