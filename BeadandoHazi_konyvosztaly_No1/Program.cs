namespace BeadandoHazi_konyvosztaly_No1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n_szam = AdatBK<int>("Adja meg hogy hany konyvet szeretne");
            Console.WriteLine(new string('|', 25));
            Konyv[] konyvek = new Konyv[n_szam];

            for (int i = 0; i < konyvek.Length; i++)
            {
                string cim = AdatBK<string>((i + 1).ToString() + " Adja meg a cim konyvet.");
                string szerzo = AdatBK<string>((i + 1).ToString() + " Adja meg a konyv szerzojet.");
                int oldalszam = AdatBK<int>((i + 1).ToString() + " Adja meg a konyv oldalszamat.");
                double ar = AdatBK<double>((i + 1).ToString() + " Adja meg a konyv arat.");

                if (ar != 0)
                {
                    konyvek[i] = new Konyv(cim, szerzo, oldalszam, ar);
                }
                else
                {
                    konyvek[i] = new Konyv(cim, szerzo, oldalszam);
                }
                Console.WriteLine(new string('*', 25));
            }

            Console.WriteLine(new string('|', 25));

            int iter = 1;
            foreach (Konyv item in konyvek)
            {
                Console.WriteLine(iter.ToString() + " " + item.ToString());
                item.Vastag_e();
                item.Draga_e();
            }

            Console.ReadKey();
        }

        private static T AdatBK<T>(string adatbksov)
        {
            while (true)
            {
                try
                {
                    Console.Write(adatbksov + " ");
                    string bekertadat = Console.ReadLine();

                    if (string.IsNullOrEmpty(bekertadat) && typeof(T) == typeof(double))
                    {
                        //return (T)Convert.ChangeType(3_000, typeof(T));
                        return default(T);
                    }

                    return (T)Convert.ChangeType(bekertadat, typeof(T));
                }
                catch (Exception er)
                {
                    Console.WriteLine("Hiba a megadott adatban! ....");
                    Console.WriteLine(er.Message);
                }
            }
        }
    }
}
