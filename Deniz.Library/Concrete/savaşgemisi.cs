using Deniz.Library.Abstract;
using System.Drawing;
using System.Windows.Forms;



//Öğrenci Adı-Soyadı:İnci KABAK
//Öğrenci Numarası:B211200061


namespace Deniz.Library.Concrete
{
   internal  class savaşgemisi : cisim
    {
        public savaşgemisi(int panelGenişliği,Size hareketAlanıBoyutları) : base(hareketAlanıBoyutları)
        {

            Center = panelGenişliği / 2;
            HareketMesafesi = Width;
        }

    }
}
