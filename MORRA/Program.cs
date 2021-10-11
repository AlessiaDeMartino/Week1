using System;

namespace MORRA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto a Morra Cinese!");
            Console.WriteLine("Inserire Nome Utente: ");
            string nome_utente = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Ok {nome_utente}, giochiamo!");
            string[] pcNumber = DrawPC();
            //Avvisa l'utente che ha effettuato la sua scelta quindi invita l'utente a fare lo stesso cioè
            //a scegliere una delle 3 opzioni tra quelle disponibili per poter giocare contro di lui.
            Console.WriteLine("Io ho scelto, tocca a te. Scegli CARTA, FORBICI O SASSO");
            string[] scelta_utente = DrawUtente();
            //Dopo la scelta dell'utente sarà quindi "valutato" il vincitore in base al confronto tra le opzioni scelte
            CheckWin(pcNumber, scelta_utente);
        }

        private static string[] DrawPC()
        {
            //int[] numbers = new int[1];
            string[] scelta_PC = new string[1];
            Random random = new Random();
            {
                int num = random.Next(1, 4);
                //numbers[0] = num;
                if (num == 1)
                    scelta_PC[0] = "SASSO";
                if (num == 2)
                    scelta_PC[0] = "CARTA";
                if (num == 3)
                    scelta_PC[0] = "FORBICE";

            }
            return scelta_PC;
        }

        private static string[] DrawUtente()
        {
            //string[] scelta_utente = new string[1];
            //Console.WriteLine("Scegli CARTA, FORBICE o SASSO");            
            //scelta_utente [0] = Convert.ToString(Console.ReadLine());
            //return scelta_utente;
            string[] scelta_utente = new string[1];
            Console.WriteLine("Scegli: [1] Per SASSO, [2] Per CARTA, [3] Per FORBICE");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 1)
                scelta_utente[0] = "SASSO";
            if (num1 == 2)
                scelta_utente[0] = "CARTA";
            if (num1 == 3)
                scelta_utente[0] = "FORBICE";

            return scelta_utente;
        }
        private static void CheckWin(string[] NumeroPC, string[] SceltaUtente)
        {
            if (SceltaUtente[0] == "SASSO" && NumeroPC[0] == "FORBICE" || SceltaUtente[0] == "CARTA" && NumeroPC[0] == "SASSO" || SceltaUtente[0] == "FORBICE" && NumeroPC[0] == "CARTA")
                Console.WriteLine("Complimenti, hai vinto!");
            if (SceltaUtente[0] == NumeroPC[0])
                Console.WriteLine("Pareggio!");
            if (NumeroPC[0] == "SASSO" && SceltaUtente[0] == "FORBICE" || NumeroPC[0] == "CARTA" && SceltaUtente[0] == "SASSO" || NumeroPC[0] == "FORBICE" && SceltaUtente[0] == "CARTA")
                Console.WriteLine("Hai Perso!");
        }
    }
}
