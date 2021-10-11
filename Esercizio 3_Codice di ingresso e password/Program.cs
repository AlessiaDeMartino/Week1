using System;

namespace Esercizio_3_Codice_di_ingresso_e_password
{///Scrivere un programma che chiede all'utente
    //di inserire il suo codice di ingresso e 
    //la password.
    //Il programma deve andare avanti finchè
    //l'utente non inserisce codice d'adesione
    //1020304 e password 1234.
    //L'utente può fare max 3 tentativi.
    class Program
    {
        static void Main(string[] args)
        {   int cont = 0;
            while (cont < 3)
            {
               
                Console.WriteLine("Inserire codice utente");
                int codut = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inserire password");
                int pass = Convert.ToInt32(Console.ReadLine());

                if (codut == 1020304 && pass == 1234)
                {
                    Console.WriteLine("Login Effettuato");
                }
                else
                    cont++;
                 }          

                if (cont==3)
                Console.WriteLine("ACCOUNT BLOCCATO");



            #region Esercizio 3 - altra versione
            int code, password;
            int attempts = 0;
            bool isSuccessful = false;
            int storedCode = 1020304;
            int storedPassword = 1234;

            do
            {
                Console.Write("Inserisci codice:  ");
                code = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inserisci password:  ");
                password = Convert.ToInt32(Console.ReadLine());

                if ((code != storedCode) || (password != storedPassword))
                {
                    Console.WriteLine("Codice o password non validi!");
                    attempts++;
                }
                else
                {
                    Console.WriteLine("Login effettuato");
                    isSuccessful = true;
                }
            } while (!isSuccessful && (attempts < 3));
            if (!isSuccessful)
                Console.WriteLine("Account bloccato!");

            #endregion


        }
    }
}

