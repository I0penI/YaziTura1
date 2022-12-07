using System.Xml;
using YaziTura1.Classes;

namespace YaziTura1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Para para = new Para();
            bool yaziMi, tahmin;
            string tahminGiris;
            Console.Write("Yazı mı (y), Tura mı (t), Çıkış (ç) ? ");
            tahminGiris = Console.ReadLine().ToLower().Trim();
            while (tahminGiris != "ç")
            {

                yaziMi = para.At();
                tahmin = tahminGiris == "y" ? true : false;
                if (tahmin == yaziMi)
                    Console.WriteLine("Tebrikler!");
                else
                    Console.WriteLine("Tekrar Deneyiniz!");
                Console.Write("Yazı mı (y), Tura mı (t), Çıkış (ç) ? ");
                tahminGiris = Console.ReadLine().ToLower().Trim();
            }


        }
    }
}