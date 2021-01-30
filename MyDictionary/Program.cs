using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> books = new MyDictionary<string, int>();
            books.Add("Çalıkuşu", 546);
            books.Add("Daha", 397);

            Console.WriteLine("Kitap Adı: " + books.Keys[0] + "  --  " + "Sayfa sayısı: " + books.Values[0]);
            Console.WriteLine("Kitap Adı: " + books.Keys[1] + "  --  " + "Sayfa sayısı: " + books.Values[1]);
        }
    }
}
