using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            // Döngüler birbirlerine benzeyen işlemleri tekrar etmek için kullanılır.

            // Bir kurs listesi oluşturalım.
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            // Yukarıda her yeni kurs eklediğimizde bu kursları yanlış bir yöntem olarak tek tek şöyle yazmak zorunda kalırdık:
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            // şeklinde, belki de yüzlerce kursu tek tek yazmak gerekirdi.

            //------------------------------------------------------------------------------------------------------------------------

            // Array/Dizi : Yukarıdaki gibi verileri dinamik olması için aşığadaki gibi dizilerde tutarız.

            string[] kurslar = new string[]
            { "Yazılım geliştirici yetiştirme kampı" , "Programlamaya başlangıç için temel kurs" , "Java" , "Python"};
            // Bu yöntem ile yalnızca veri kaynağına yeni bir kursu yazmamız yeterli olacaktır.
            // Aslında dizi string[] kurslar = kurslariGetir(); şeklinde bir veri kaynağından gelir.

            for (int i = 0; i < kurslar.Length; i++) // i++ (i=i+1) birer birer arttırır. i+=2 (i=i+2) ikişer ikişer.
            {
                Console.WriteLine(kurslar[i]); // kurslar'ın i'ninci elemanını ekrana yazdırmasını söyledik.
            }

            Console.WriteLine("for döngüsü bitti");

            //------------------------------------------------------------------------------------------------------------------------

            // foreach : dizi temelli yapıları tek tek dönmeye yarar. Dizilere uygulanırlar. (i formülünü uygulamaya gerek kalmıyor)

            foreach (string kurs in kurslar) // in kurslar - kurslar içerisinde tek tek dolaş demektir. (aslında yapının tamamı dolaş demektir)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("foreach döngüsü bitti");

            int x = 0;
            while ( x < kurslar.Length)
            {
                Console.WriteLine(kurslar[x]);
                x++;
            }

            Console.WriteLine("while döngüsü bitti");

            Console.WriteLine("Sayfa Sonu!/Footer");

        }
    }
}


