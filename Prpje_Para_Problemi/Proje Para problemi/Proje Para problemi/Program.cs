using System;

namespace Proje_Para_problemi
{
    class Program
    {
        static void Main(string[] args)
        {
            int ParaMik = 0;
            Console.Write("Ödenecek Para Tutarını Yazınız: ");
            ParaMik = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            int a200 = 0, a100 = 0, a50 = 0, a20 = 0, a10 = 0, a5 = 0, a1 = 0;

            //200 lük banknot adedi
            if (ParaMik >= 200)
            {
                a200 = ParaMik / 200;
                ParaMik = ParaMik % 200;
            }

            //100 lük banknot adedi
            if (ParaMik >= 100)
            {
                a100 = ParaMik / 100;
                ParaMik = ParaMik % 100;
            }

            //50 lik banknot adedi
            if (ParaMik >= 50)
            {
                a50 = ParaMik / 50;
                ParaMik = ParaMik % 50;
            }

            //20 lik banknot adedi
            if (ParaMik >= 20)
            {
                a20 = ParaMik / 20;
                ParaMik = ParaMik % 20;
            }

            //10 luk banknot adedi
            if (ParaMik >= 10)
            {
                a10 = ParaMik / 10;
                ParaMik = ParaMik % 10;
            }

            //5 lik banknot adedi
            if (ParaMik >= 5)
            {
                a5 = ParaMik / 5;
                ParaMik = ParaMik % 5;
            }

            //1 lik banknot adedi
            if (ParaMik >= 1)
            {
                a1 = ParaMik / 1;
                ParaMik = ParaMik % 1;
            }

            Console.WriteLine("200'lük Banknot Adedi   : " + a200);
            Console.WriteLine("100'lük Banknot Adedi   : " + a100);
            Console.WriteLine("50'lik Banknot Adedi    : " + a50);
            Console.WriteLine("20'lik Banknot Adedi    : " + a20);
            Console.WriteLine("10'luk Banknot Adedi    : " + a10);
            Console.WriteLine("5'lik Banknot Adedi     : " + a5);
            Console.WriteLine("1'lik Metal Para Adedi  : " + a1);
            Console.ReadKey();
        }
    }
}
