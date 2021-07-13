using System;

namespace Week1Day2.Esercizio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrivere un programma che consente all'utente di inserire due numeri,
            //scegliere che operazione compiere tra i due numeri e stampare il risultato. 
            //A questo punto, l'utente deve poter ricominciare dall'inserimento dei numeri, 
            //finchè non sceglie di uscire.
            
            do
            {
                Console.WriteLine("\nInserisci il primo numero");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo numero");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("*****Menu*****");
                Console.WriteLine("1. Somma");
                Console.WriteLine("2. Sottrazione");
                Console.WriteLine("3. Moltiplicazione");
                Console.WriteLine("4. Divisione");

                int scelta = int.Parse(Console.ReadLine());
                int result;
                switch (scelta)
                {
                    case 1:
                        result = a + b;
                        Console.WriteLine($"Risultato= {result}");
                        break;
                    case 2:
                        result = a - b;
                        Console.WriteLine($"Risultato= {result}");
                        break;
                    case 3:
                        result = a * b;
                        Console.WriteLine($"Risultato= {result}");
                        break;
                    case 4:
                        if (b != 0)
                        {
                            double resultDouble= (double)a / b;
                            Console.WriteLine($"Risultato= {resultDouble}");
                        }
                        else
                        {
                            Console.WriteLine("Operazione Impossibile");
                        }
                        break;
                    default:
                        Console.WriteLine("Scelta errata");
                        break;
                }
                
                Console.WriteLine("Vuoi continuare? Scrivi 'si' per continuare.");
            } while (Console.ReadLine()=="si");
        }
    }
}
