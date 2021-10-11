using System;

namespace ordinare_array_in_modo_crescente
{  //Dato un array di 5 interi, ordinare gli elementi
   //in ordine crescente.
   //Stampare l'array ordinato
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 17, 34, 5, 90, 58 }; 
            //controllo se è in ordine crescente o decrescente
            for (int i=0; i< a.Length; i++)
            {
                if (a[i] > a[i + 1])
                    Console.WriteLine("Ordine non crescente");
                else
                {
                    Console.WriteLine("Ordine crescente");
                }
            }
            //bool ordineCorretto = true;
            //for (int j=0; j<a.Length;j++)
            //    if (a[j]>a[j+1])
            //    {
            //        ordineCorretto = false;
            //        break;
            //    }
            //if (ordineCorretto == true)
            //    Console.WriteLine("Array ordine crescente");
            //else
            //{
            //    Console.WriteLine("Array non in ordine crescente");
            //RIORDINO
            for (int k=0; k<a.Length-1; k++)
            { 
                for (int l=k+1; l<a.Length; l++)
                {
                    if (a[k] > a[l])
                    {
                        int x = a[k];
                        a[k] = a[l];
                        a[l] = x;
                    }
                                    }

            }
            foreach (int c in a)
                Console.WriteLine($"{c}");

       }
    }
}
