
/******************************************************************************
                       KALAN HAK KODLARI
*******************************************************************************/


class HelloWorld
{
    static void Main()
    {
        int sayi, hak = 10, toplam = 0;

        do
        {
            Console.Write("Sayı giriniz : ");
            sayi = int.Parse(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                toplam += sayi;
            }
            else
            {
                hak--;
                Console.WriteLine("Kalan Hak : {0}", (hak));
            }
        }
        while (hak > 0);
        Console.WriteLine("Toplam : {0}", (toplam));
    }
}