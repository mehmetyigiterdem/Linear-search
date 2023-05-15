using System;

class Program
{
    static void Main()
    {
        Console.Write("Dizi boyutunu girin: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        Console.WriteLine("Dizi elemanlarını girin:");

        for (int i = 0; i < size; i++)
        {
            Console.Write("Eleman {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Aranacak elemanı girin: ");
        int aranan = Convert.ToInt32(Console.ReadLine());

        bool bulundu = false;
        for (int i = 0; i < size; i++)
        {
            if (arr[i] == aranan)
            {
                bulundu = true;
                break;
            }
        }

        if (bulundu)
            Console.WriteLine("Aranan eleman dizide bulundu!");
        else
            Console.WriteLine("Aranan eleman dizide bulunamadı!");

        Console.ReadLine();
    }
}
