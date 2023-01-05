

using Deniz.Library.Abstract;
using System;
using System.Drawing;



//Öğrenci Adı-Soyadı:İnci KABAK
//Öğrenci Numarası:B211200061





namespace Deniz.Library.Concrete
{
    internal class mermi : cisim
    {
        public mermi(Size hareketAlanıBoyutları, int namluOrtasıX) : base(hareketAlanıBoyutları)
        {
            BaslangıcKonumunuAyarla(namluOrtasıX);
            HareketMesafesi=(int) (Height * 1.5);

        }

        private void BaslangıcKonumunuAyarla(int namluOrtasıX)
        {
            Bottom = HareketAlanıBoyutları.Height;
            Center = namluOrtasıX;
        }
    }
}
