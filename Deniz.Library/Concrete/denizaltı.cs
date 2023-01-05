

using Deniz.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;


//Öğrenci Adı-Soyadı:İnci KABAK
//Öğrenci Numarası:B211200061




namespace Deniz.Library.Concrete
{
    internal class denizaltı : cisim 
    {
        private static readonly Random Random = new Random();
        public denizaltı(Size hareketAlanıBoyutları) : base(hareketAlanıBoyutları)
        {
            HareketMesafesi = (int) (Height * .1);
            Left = Random.Next(hareketAlanıBoyutları.Width - Width +1 );
        }

        public mermi VurulduMu(List<mermi> mermiler)
        {
            foreach (var mermi in mermiler)
            {
                var vurulduMu = mermi.Top < Bottom && mermi.Right > Left && mermi.Left < Right;
                if (vurulduMu) return mermi;
            }
            return null;

           

        }
    }
}
