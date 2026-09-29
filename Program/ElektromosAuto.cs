using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class ElektromosAuto : Jarmu
    {
            private int akkumulatorSzint;

            public int AkkumulatorSzint
            {
                get { return akkumulatorSzint; }
                set
                {
                    if (value < 0)
                {
                        akkumulatorSzint = 0;
                }
                    else if (value > 100)
                {
                        akkumulatorSzint = 100;
                }
                    else
                {
                        akkumulatorSzint = value;
                }
                }
            }

            public ElektromosAuto(string rendszam, int kor, int kilometerOra, int akkumulatorSzint)
                : base(rendszam, kor, kilometerOra, 0)
            {
                AkkumulatorSzint = akkumulatorSzint;
            }

            public override void InformaciotAd()
            {
                Console.WriteLine($"{Rendszam} - {Kor} éves elektromos autó, {KilometerOra} km-rel, {AkkumulatorSzint} % töltöttséggel.");
            }

            public override void Szervizel(int dij)
            {
                if (dij > 100000)
                {
                    KilometerOra -= 10000;
                }

                AkkumulatorSzint += 20;

                Console.WriteLine("A jármű szervizelése megtörtént.");
            }
        }

    }

