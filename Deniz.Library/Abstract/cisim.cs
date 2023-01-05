using Deniz.Library.Enum;
using Deniz.Library.İnterface;
using System;
using System.Drawing;
using System.Windows.Forms;


//Öğrenci Adı-Soyadı:İnci KABAK
//Öğrenci Numarası:B211200061




namespace Deniz.Library.Abstract
{
    internal abstract class cisim : PictureBox, IHareketEden
    {
        protected cisim(Size hareketAlanıBoyutları)
        {
            HareketAlanıBoyutları = hareketAlanıBoyutları;
        }

        public Size HareketAlanıBoyutları { get; }

        public int HareketMesafesi { get; protected set; }

        public new int Right 
        {
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom { 
            get => base.Right;
            set => Left = value - Width;
        }

        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }

        /*
        protected cisim(Size HareketAlanıBoyutları)
        {
            Image = Image.FromFile($@"Görseller\{GetType().Name}.jpg");
            HareketAlanıBoyutları = HareketAlanıBoyutları;
            SizeMode = PictureBoxSizeMode.AutoSize;
        }

        */
        
        public bool HareketEttir(Yön yön)
        {
            switch (yön)
            {
                case Yön.Yukari:
                    return YukariHareketEttir();
                case Yön.Sağa:
                    return SagaHareketEttir();
                case Yön.Aşağı:
                    return AsağiHareketEttir();
                case Yön.Sola:
                    return SolaHareketEttir();
                default:
                    throw new ArgumentOutOfRangeException(nameof(yön), yön, null);
            }

        }

        private bool SolaHareketEttir()
        {
            if (Left == 0) return true;

            var yeniLeft = Left - HareketMesafesi;
            var tasacakMi = yeniLeft < 0;
            Left=tasacakMi ? 0 : yeniLeft;

            return Left == 0;
        }

        private bool AsağiHareketEttir()
        {
            if (Bottom == HareketAlanıBoyutları.Height) return true;

            var yeniBottom = Bottom + HareketMesafesi;
            var tasacakMi = yeniBottom > HareketAlanıBoyutları.Height;

            Bottom = tasacakMi ? HareketAlanıBoyutları.Height : yeniBottom;

            return Bottom == HareketAlanıBoyutları.Height;
        }

        private bool SagaHareketEttir()
        {
            if (Right == HareketAlanıBoyutları.Width) return true;

            var yeniRight = Right + HareketMesafesi;
            var tasacakMi = yeniRight > HareketAlanıBoyutları.Width;

            Right = tasacakMi ? HareketAlanıBoyutları.Width : yeniRight;
            
            return Right == HareketAlanıBoyutları.Width;
        }

        private bool YukariHareketEttir()
        {
            if (Top == 0) return true;

            var yeniTop = Top - HareketMesafesi;
            var tasacakMi = yeniTop < 0;
            Top = tasacakMi ? 0 : yeniTop;

            return Top == 0;
        }

     
    }


}

