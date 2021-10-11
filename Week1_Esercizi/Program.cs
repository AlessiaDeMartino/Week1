using System;

namespace Week1_Esercizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire una stringa: ");
            string stringax = Console.ReadLine();
            Console.WriteLine("Inserire un carattere: ");
            char caratt = Console.ReadKey().KeyChar;
            int cont = 0;
            foreach (char c in stringax)
            {
                if (c == caratt)
                    cont++;


            }
            Console.WriteLine($"\nIl carattere {caratt} è contenuto {cont} volte nella stringa {stringax}");

        }
    }
}

