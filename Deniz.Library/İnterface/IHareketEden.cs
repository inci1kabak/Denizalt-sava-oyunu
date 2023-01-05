using Deniz.Library.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Öğrenci Adı-Soyadı:İnci KABAK
//Öğrenci Numarası:B211200061





namespace Deniz.Library.İnterface
{
    internal interface IHareketEden
    {
        Size HareketAlanıBoyutları { get; }
        int HareketMesafesi { get; }
        bool HareketEttir(Yön yön);
    }
}
