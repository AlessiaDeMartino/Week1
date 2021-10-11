using System;

namespace Calcolatrice
{ /*Calcolatrice.
 Realizzare un programma che chiede all'utente di inserire due numeri e di scegliere se
 calcolare la somma, sottrazione, divisione o moltiplicazione.
 Il programma stampa il risultato e chiede all'utente se vuole eseguire un altro calcolo.
 Se l'utente sceglie di continuare, il programma chiedere di nuovo all'utente di inserire
 due numeri, altrimenti esce dal programma.
   */
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Benvenuto! Inserire un numero: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Benvenuto! Inserire un numero: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Scegliere operazione da effettuare: [1] Somma" +
                    "[2] Sottrazione" +
                    "[3] Divisione" +
                    "[4] Moltiplicazione");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case '1':
                        int sum = a + b;
                        Console.WriteLine($"Il risultato della somma è: {sum}");
                        break;

                    case '2':
                        int diff = a - b;
                        Console.WriteLine($"Il risultato della sottrazione è: {diff}");
                        break;

                    case '3':
                        if (b == 0)
                        {
                            Console.WriteLine("Impossibile");
                        }
                        else
                        {
                            int quoziente = a / b;
                            Console.WriteLine($"Il quoziente è {quoziente}");
                        }
                        break;

                    case '4':
                        int prod = a * b;
                        Console.WriteLine($"Il prodotto è: {prod}");
                        break;
                }
                Console.WriteLine("Vuoi eseguire un altro calcolo? Premere S per ricalcolare, qualsiasi altro tasto per uscire");

            } while (Console.ReadKey().KeyChar == 'S');
            //while(Console.ReadLine()=='S');


        }
    }
}
