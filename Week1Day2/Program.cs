using System;

namespace Week1Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esempio1();
            //Esempio2();
            //Esempio3();
            //Esempio4();
            //Esempio5();

            //istruzioni di salto: break, continue, return.

            for (int i = 4; i >=0 ; i--)
            {
                Console.Write($"{i}\t");
            }
            // 4 3 2 1 0

            //continue;
            Console.WriteLine("\nesempio con continue");

            for(int i=4; i >= 0; i--)
            {
                if (i == 2)
                {
                    continue;
                }
                else
                {
                    Console.Write($"{i}\t");
                }
            }
            //break;
            Console.WriteLine("\nesempio con break");
            for (int i = 4; i >= 0; i--)
            {
                if (i == 2)
                {
                    break;
                }
                else
                {
                    Console.Write($"{i}\t");
                }
            }
            Console.WriteLine("Ciao");
            
            //return;
            Console.WriteLine("\nesempio con return");
            for (int i = 4; i >= 0; i--)
            {
                if (i == 2)
                {
                    return;
                }
                else
                {
                    Console.Write($"{i}\t");
                }
            }
            Console.WriteLine("Ciao mai stampato");

        }

        private static void Esempio5()
        {
            //While - For - do While 

            //For
            //si usa il numero di iterazioni è noto e non c'è necessità di interrompere il ciclo.
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Valore: {i + 1}");
            }

            //While
            // si usa quando si possono avere potenzialmente anche zero iterazioni
            // e comunque quando non si sa a priori quante se ne faranno
            Console.WriteLine("Inserisci un numero maggiore di 10");
            int num = int.Parse(Console.ReadLine());

            while (num < 10)
            {
                Console.WriteLine("Numero errato. Inserisci un numero maggiore di 10");
                num = int.Parse(Console.ReadLine());
            }


            int j = 0;
            while (j < n)
            {
                Console.WriteLine($"While-Valore: {j + 1}");
                j++;
            }

            //Do-While
            //si usa quando si deve fare almeno un'iterazione e non si sa a priori quante se ne faranno.
            int num1;
            do
            {
                Console.WriteLine("Inserisci un numero maggiore di 5");
                num1 = int.Parse(Console.ReadLine());

            } while (num1 < 5);
        }

        private static void Esempio4()
        {
            //Espressioni condizionali
            Console.WriteLine("Inserisci un numero intero");
            int number;
            string s = Console.ReadLine();
            number = int.Parse(s);

            if (number > 10)
            {
                Console.WriteLine("Il numero è maggiore di 10");
            }
            else //non obligatorio
            {
                Console.WriteLine("Il numero è minore o uguale a 10");
            }

            if (number <= 10 && number >= 1)
            {
                Console.WriteLine("Il numero inserito è compreso tra 1 e 10");
            }
            else if (number > 10 && number <= 20)
            {
                Console.WriteLine("Il numero inserito è compreso tra 11 e 20");
            }
            else
            {
                Console.WriteLine("Il numero inserito è maggiore di 20");
            }

            //Switch

            Console.WriteLine("Inserisci un numero tra 1 e 3");
            int numScelto = int.Parse(Console.ReadLine());

            if (numScelto == 1)
            {
                Console.WriteLine("Uno");
            }
            else if (numScelto == 2)
            {
                Console.WriteLine("Due");
            }
            else if (numScelto == 3)
            {
                Console.WriteLine("Tre");
            }
            else
            {
                Console.WriteLine("Scelta non valida");
            }

            Console.WriteLine("Stampa con switch");
            switch (numScelto)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Due");
                    break;
                case 3:
                    Console.WriteLine("Tre");
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }

            Console.WriteLine("Scegli un carattere tra A e B");
            char carattereScelto = Console.ReadKey().KeyChar;

            switch (carattereScelto)
            {
                case 'A':
                    Console.WriteLine("\nHai scelto A");
                    break;
                case 'B':
                    Console.WriteLine("\nHai scelto B");
                    break;
                default:
                    Console.WriteLine("\nScelta errata");
                    break;
            }
        }

        private static void Esempio3()
        {
            //Casting

            int a = 2;
            long b = a; //cast implicito

            int c;
            long d = 99999999999999999;
            c = (int)d; //cast esplicito. Potenziale perdita di informazione/precisione
            //c = Convert.ToInt32(d); //se non è possibile la conversione, si blocca
            Console.WriteLine(c);


            string s = "123";
            //int n = (int)s; //errore

            int n = int.Parse(s);
            //int n = Convert.ToInt32(s);
            Console.WriteLine(n);

            string s1 = "3.89";
            double d1 = double.Parse(s1);
            double d2 = Convert.ToDouble(s1);


            //Enum
            Genere gen = Genere.femmina;
            int f = (int)gen;
            int m = 1;
            Genere gen1 = (Genere)m;
        }

        enum Genere
        {
            maschio = 1,
            femmina = 2
        }

        private static void Esempio2()
        {
            //Operazioni
            //bool
            bool x, y = true;

            x = true;
            x = !y; //false;
            x = (18 > 9); //true;

            x = true;
            y = false;
            bool z = x && y; //false;            
            z = x || y; //true;

            //Interi
            int i, j;
            i = 2;
            j = i + 1; //3 

            int a = 5;
            int b = 2;
            int c = a / b; //2
            int r = a % b; //1   5=2*2+1

            //double d = (double)a / b;

            //incremento ++  Idem per decremento --
            int k = 23;
            //k=k+1;
            //k++;
            //++k;
            k = ++i; //k=3 i=3
            k = i++; //k=3; i=4;
            Console.WriteLine($"k={k}");
            Console.WriteLine($"i={i}");

            k += 3; //k=k+3;
            Console.WriteLine($"k={k}");

            int m = 23;
            m += 3;
            Console.WriteLine($"m={m}");
        }

        private static void Esempio1()
        {
            int age = 18;
            //age = null; da errore
            bool y = true; // false

            string s1 = "Hello";
            string s2 = null;
            string s3 = "";

            object obj1 = new object();
            object obj2 = null;
            object obj3 = obj1;

            //Type inference
            int numero = 20;
            var numero2 = 30;

            var s = "Ciao";
            //var s1 = null; errore.
        }
    }
}
