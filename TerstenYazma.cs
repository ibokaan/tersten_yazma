using System;

class TerstenYazma
{
    static void Main()
    {
        Console.WriteLine("==== Tersten Yazma ====");

        while (true)
        {
            Console.Write("Tersine çevirmek istediğiniz metni girin (Çıkmak için boşluk tusuna bas): ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                break;

            string ters = TersCevir(input);

            Console.WriteLine("Tersine: " + ters);
            Console.WriteLine();
        }

        Console.WriteLine("Programdan çıkılıyor...");
    }

    static string TersCevir(string metin)
    {
        char[] dizi = metin.ToCharArray();
        Array.Reverse(dizi);
        return new string(dizi);
    }
}