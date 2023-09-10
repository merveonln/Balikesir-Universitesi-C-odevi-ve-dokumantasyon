using System;

namespace Proje_EgikAtıs_menzil
{
    class Program
    {
        //•	ÖNEMLİ NOT!!!
        //TEK VE EN ÖNEMLİ HATA(PROJENİN EKSİKLİĞİ) HIZI EN FAZLA 10,
        //AÇISI EN FAZLA 75’E KADAR ÇALIŞIYOR.(YÖRÜNGE İÇİN) DÜZELTEMEDİM.
        //EKSİKLİĞİ GİDEREMEDİM AMA ELİMDEN GELENİ YAPTIM.
        //açısını 10, hızını 75 giriniz.

        public static double Funksioni(double x)
        {
            double y;

            y = Math.Sin(x);

            return y;
        }
        static void Main(string[] args)
        {
            int[,] SK = new int[81, 49];
            int j;
            double k;

            double firlatmahizi, firlatmaacisi;
            double g = 9.81;
            double maxyukseklik, menzil, uçuşsuresi;
            double Vxo, Vyo;
            Console.WriteLine("*****Console Penceresini 80,24 boyutlarına ayarlayınız*****");
            Console.Write("Fırlatma Hızını Giriniz : ");
            firlatmahizi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fırlatma Açısını Giriniz : ");
            firlatmaacisi = Convert.ToInt32(Console.ReadLine());
            Vxo = firlatmahizi * Math.Cos(firlatmaacisi * Math.PI / 180);
            Vyo = firlatmahizi * Math.Sin(firlatmaacisi * Math.PI / 180);
            maxyukseklik = Convert.ToSingle((Vyo * Vyo) / (2 * g));
            uçuşsuresi = Convert.ToSingle(2 * Vyo / g);
            menzil = Convert.ToSingle(Vxo * uçuşsuresi);
            Console.WriteLine("Maksimum Yükseklik : " + maxyukseklik);
            Console.WriteLine("Menzili : " + menzil);
            Console.WriteLine("Uçuş Süresi : " + uçuşsuresi);

            Console.WriteLine("Yörünge Çiziliyor... Bir tuşa basınız...");
            Console.ReadKey();

        for (int a = 0; a <= 48; a++)
        {
            for (int b = 0; b <= 80; b++)
            {
                    SK[b, a] = 0;
            }
        }


        for (double i = 0; i < 360; i++)
        {
                int z = Convert.ToInt16((i + 180) / 12) * Convert.ToInt16(menzil / 10);

                k = 12 + maxyukseklik * -Funksioni((i * Math.PI) / 360);
                j = Convert.ToInt16(k);

                if (j <= 48 & j > 0)
                    SK[z, j] = 1;
                SK[z, j] = 2;
                SK[z, j] = 3;
            }


        for (int y = 1; y <= 12; y++)
        {
                if (y == 12)
                    for (int d = 0; d <= 79; d++)

                        if (SK[d, 12] == 0)
                            if (d == 15)
                                Console.Write(".");
                            else
                                Console.Write("-");
                        else
                            Console.Write("*");

                else
                {
                    for (int x = 0; x <= 79; x++)
                    {
                        if (SK[x, y] == 0)
                            if (x == 15)
                                Console.Write("|");
                            else
                                Console.Write(" ");
                        else
                        {

                            Console.Write("*");
                        }
                    }

                }
        }
    }
    }
}
