using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string rendszam;
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;
        private bool szervizSzukseges;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            Rendszam = rendszam;
            Kor = kor;
            KilometerOra = kilometerOra;
            UzemanyagSzint = uzemanyagSzint;
        }

        public string Rendszam
        {
            get =>  rendszam;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    rendszam = "ISMERETLEN";
                }
                else
                {
                    rendszam = value;
                }
            }
        }

        public int Kor
        {
            get => kor;
            set
            {
                if (value < 0)
                {
                    kor = 0;
                }
                else if (value > 50)
                {
                    kor = 50;
                }
                else
                {
                    kor = value;
                }
            }
        }

        public int KilometerOra
        {
            get => kilometerOra;
            set
            {
                if (value < 0)
                {
                    kilometerOra = 0;
                }
                else
                {
                    kilometerOra = value;
                }

                SzervizSzukseges = kilometerOra >= 200000;
            }
        }

        public int UzemanyagSzint
        {
            get => uzemanyagSzint;
            set
            {
                if (value < 0)
                {
                    uzemanyagSzint = 0;
                }
                else if (value > 100)
                {
                    uzemanyagSzint = 100;
                }
                else
                {
                    uzemanyagSzint = value;
                }
            }
        }
        public bool SzervizSzukseges
        {
            get => szervizSzukseges;
            set
            {
                if(kilometerOra >= 200000)
                {
                    szervizSzukseges = true;
                }
            }
        }

        public virtual void  InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km-rel.");
        }
        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
                if (KilometerOra < 0)
                    KilometerOra = 0;
            }
            UzemanyagSzint -= 10;
            if (UzemanyagSzint < 0)
                UzemanyagSzint = 0;
            Console.WriteLine("A jármű szervizelése megtörtént");
        }
    }
}
