using Deniz.Library.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Öğrenci Adı-Soyadı:İnci KABAK
//Öğrenci Numarası:B211200061






namespace Deniz.Library.İnterface
{
    internal interface IOyun
    {
        event EventHandler GeçenSüreDeğişti;
        bool DevamEdiyorMu { get; }
        TimeSpan GeçenSüre { get; }

        void Baslat();
        void AtesEt();
        void SavasGemisiniHareketEttir(Yön yön);
    }
}
