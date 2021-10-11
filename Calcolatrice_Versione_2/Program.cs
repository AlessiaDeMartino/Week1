using System;

namespace Calcolatrice_Versione_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcolatrice.
            //Realizzare un programma che chiede all'utente di inserire due numeri e di scegliere se
            //calcolare la somma, sottrazione, divisione o moltiplicazione.

            //Il programma stampa il risultato e chiede all'utente se vuole eseguire un altro calcolo.

            //Se l'utente sceglie di continuare, il programma chiedere di nuovo all'utente di inserire
            //due numeri, altrimenti esce dal programma.

            char chosenOption;
            bool goOn = true;

            while (goOn)
            {
                //1) Chiedo i numeri all'utente e salvo ciò che ha inserito in a e b
                Console.WriteLine("Inserisci il primo numero");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Inserisci il secondo numero");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("*****Scegli l'operazione*****");
                Console.WriteLine("[1] Somma");
                Console.WriteLine("[2] Sottrazione");
                Console.WriteLine("[3] Moltiplicazione");
                Console.WriteLine("[4] Divisione");

                //2) Recupero la scelta dell'operazione 
                chosenOption = Console.ReadKey().KeyChar;

                int result;
                //int result = 0; //da scommentare se ci vuole usare il ciclo if sotto

                switch (chosenOption)
                {
                    case '1':
                        result = a + b;
                        Console.WriteLine($"{a} + {b} = {result}");
                        break;
                    case '2':
                        result = a - b;
                        Console.WriteLine($"{a} - {b} = {result}");
                        break;
                    case '3':
                        result = a * b;
                        Console.WriteLine($"{a} * {b} = {result}");
                        break;
                    case '4':
                        if (b != 0)
                        {
                            result = a / b;
                            Console.WriteLine($"{a} / {b} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Operazione Impossibile");
                        }
                        break;
                    default:
                        Console.WriteLine("Scelta non valida");
                        break;
                }


                Console.WriteLine("Vuoi continuare? Premi 'Y' per continuare " +
                    "o qualunque altro tasto per uscire");

                if (Console.ReadLine() != "Y")
                {
                    goOn = false;
                }
            }
        }
    }
}
