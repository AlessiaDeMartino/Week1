using System;

namespace ERBORISTERIA
{
    class Program
    {
        static void Main(string[] args)
        {
            //I prodotti trattati da un'erboristeria sono memorizzati in 4 vettori paralleli.
            //codici -> codice di ciascun prodotto (ogni codice è una stringa)
            //nomi -> nome del prodotto
            //classi -> tipologia di prodotto(cosmetici, integratori, infusi...)
            //prezzi -> prezzo del prodotto

            //Caricare i vettori(almeno due prodotti per classe).

            //Realizzare un programma che, all'accesso, stampa un menu in cui chiede all'utente di scegliere 
            //cosa vuole fare.
            //1. Stampare i dati relativi al prodotto di prezzo massimo
            //2. Stampare i dati relativi a un determinato prodotto il cui codice è fornito in input
            //3. Stampare tutti i prodotti di una categoria
            //I prezzi stanno subendo un AUMENTO. 
            //4. Aggiornare il prezzo di un prodotto 
            //Q. Uscire

            //Una volta conclusa un'operazione, viene presentato di nuovo il menu.
            //Se l'utente sceglie di uscire, il programma si interrompe.

            string[] codes = new string[] { "P1", "P2", "P3", "P4", "P5", "P6" };
            string[] names = new string[] { "MASCARA BIO", "FONDOTINTA NATURE", "ENERGIA PLUS", "CONCENTRAZIONE SUPER", "RELAX TIME", "DIGESTIVE" };
            string[] categories = new string[] { "COSMETICI", "COSMETICI", "INTEGRATORI", "INTEGRATORI", "INFUSI", "INFUSI" };
            double[] prices = new double[] { 5.99, 6.99, 3.99, 2.99, 1.99, 3.99 };

            bool exit = true;

            do
            {
                Console.WriteLine("*** Menu *** " +
                    "\nScegli un'opzione" +
                    "\n[1] Stampare i dati relativi al prodotto di prezzo massimo" +
                    "\n[2] Stampare i dati relativi a un prodotto tramite codice fornito in input" +
                    "\n[3] Stampare tutti i prodotti di una categoria" +
                    "\n[Q] Uscire");

                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        //1. Ricavo il prezzo massimo tra i prezzi nel vettore prices

                        //5.99, 6.99, 3.99, 2.99, 1.99, 9.99

                        double max = 0.0;
                        int index = 0;
                        for (int i = 0; i < prices.Length; i++)
                        {
                            if (prices[i] > max)
                            {
                                max = prices[i];
                                index = i;
                            }
                        } //finito il ciclo, i muore qui => finito il ciclo, non la vedo più

                        //Console.Clear();

                        //2. Recupero e stampo i dati del prodotto con indice = index, ovvero l'indice del prezzo massimo
                        Console.WriteLine($"\n{codes[index]} - {names[index]} in {categories[index]} {prices[index]}");

                        break;
                    case '2':
                        //1. Chiedere all'utente il codice del prodotto di cui vedere i dettagli
                        //2. Se il codice inserito è uno dei codice nel vettore codes => stampa i dettagli
                        //3. Se il codice inserito non è tra i codici nel vettore codes => "Non esiste un prodotto con questo codice"

                        string chosenCode = GetChosenCode(codes);

                        if (chosenCode != null)
                        {
                            for (int i = 0; i < codes.Length; i++)
                            {
                                if (codes[i] == chosenCode)
                                {
                                    Console.WriteLine($"{codes[i]} - {names[i]} in {categories[i]} {prices[i]}");
                                }
                            }
                        }
                        break;
                    case '3':
                        //Chiedo all'utente di quale categoria vuole vedere i prodotti
                        //Se l'utente sceglie una categoria esistente, stampo i prodotti di quella categoria 
                        //Altrimenti, richiedo di inserire la categoria

                        //1. Chiedo all'utente di quale categoria vuole vedere
                        //i prodotti
                        FetchCategories(categories);

                        string chosenCat = null;

                        while (chosenCat == null)
                        {
                            chosenCat = GetChosenCategory(categories);
                        }

                        if (chosenCat != null)
                        {
                            for (int i = 0; i < categories.Length; i++)
                                if (categories[i] == chosenCat)
                                {
                                    Console.WriteLine($"{codes[i]} - {names[i]} " +
                                 $"in {categories[i]} Prezzo: {prices[i]}");
                                }
                        }
                        break;
                    case '4':
                        //Chiedo all'utente di quale prodotto vuole aggiornare il prezzo
                        //Esempio: stampo tutti i prodotti a video -> utente sceglie che prodotto 
                        //aggiornare, digitando il codice (univoco)
                        //A questo punto, bisogna modificare l'elemento prezzo nel vettore prezzi, all'indice 
                        //del prodotto scelto. 
                        //Non si può accettare un prezzo minore del vecchio prezzo perchè la traccia dice
                        //che i prezzi sono in aumento! 

                        break;
                    case 'Q':
                        exit = false;
                        break;
                }
            }
            while (exit);

        }

        private static string GetChosenCode(string[] productsCodes)
        {
            bool codeExists = false;
            string code = null;

            while (!codeExists)
            {
                Console.WriteLine("Inserisci il codice del prodotto");
                code = Console.ReadLine();

                for (int i = 0; i < productsCodes.Length; i++)
                {
                    if (productsCodes[i] == code)
                    {
                        codeExists = true;
                        return code;
                    }
                }
            }

            return code;
        }

        private static string GetChosenCategory(string[] categories)
        {
            Console.WriteLine("Inserisci il nome della categoria del prodotto");
            string cat = Console.ReadLine().ToUpper();

            for (int i = 0; i < categories.Length; i++)
            {
                if (categories[i] == cat)
                {
                    return cat;
                }
            }

            return null;
        }

        private static void FetchCategories(string[] categories)
        {
            string[] storeCategories = new string[categories.Length]; //creo un array che ha dimensione 6

            int count = 0;
            for (int i = 0; i < storeCategories.Length; i++)
            {
                int found = -1;

                found = Array.IndexOf(storeCategories, categories[i]); //verifico se l'i-esima categoria del vettore categories
                                                                       //è contenuta nel nuovo vettore di categorie che voglio stampare
                if (found == -1) //se non c'è, la inserisco nel vettore che voglio stampare
                {
                    storeCategories[count] = categories[i];
                    count++; //incremento il contatore (alla fine conterrà il numero di elementi
                             //che avrò messo nell'array storeCategories
                }
            }

            Array.Resize(ref storeCategories, count);
            //prende un array e un numero e
            //ridimensiona l'array con dimensione pari al numero passato
            //nel nostro caso prende il vettore storeCategorie
            //e da 6 lo ridimensiona a 3

            foreach (string c in storeCategories) //stampo le categorie 
                Console.WriteLine(c);
        }
    }
}
