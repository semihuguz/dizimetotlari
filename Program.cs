using System;

namespace dizi_array_metot // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   //sort

             Console.WriteLine("***********Sort**************");

            Console.WriteLine("Duzensiz Dizi");
            int[] sayiDizisi = {19,28,37,46,55,6,7,21,3,};
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("Sirali dizi");
            Array.Sort(sayiDizisi);


            //clear 
            Console.WriteLine("******Clear*********");
            Array.Clear(sayiDizisi,2,3);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //Reverse
            Console.WriteLine("***********Reverse **************");

            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //indexof
            Console.WriteLine("***********Index Of **************");
            Console.WriteLine(Array.IndexOf(sayiDizisi,5));

            Console.WriteLine("***********Resize **************");

            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[10]= 100;



        }  
        
    }
}