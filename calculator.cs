using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Cicli
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            float n2;
            int scelta;
            string continua;

            do
            {
                Console.Clear();
                Console.WriteLine("Benvenuto nella mia calcolatrice \nSeleziona l'operazione da eseguire");
                Console.WriteLine("0-Somma \n1-Differenza \n2-Prodotto \n3-Divisione \n4-Esci");
                scelta = Convert.ToInt32(Console.ReadLine());
                if (scelta != 4)
                {
                    Console.Write("Inserisci il primo numero: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Inserisci il secondo numero: ");
                    n2 = Convert.ToInt32(Console.ReadLine());

                    switch (scelta)
                    {
                        case 0:
                            Console.WriteLine(+n1 + "+" + n2 + "=" + (n1 + n2));
                            break;
                        case 1:
                            Console.WriteLine(+n1 + "-" + n2 + "=" + (n1 - n2));
                            break;
                        case 2:
                            Console.WriteLine(+n1 + "*" + n2 + "=" + (n1 * n2));
                            break;
                        case 3:
                            Console.WriteLine(+n1 + "/" + n2 + "=" + (n1 / n2));
                            break;
                    }
                }
                else { return; }
                Console.WriteLine("Inserisci si per continuare");
                continua = Console.ReadLine();
            } while (continua == "si");
            Console.ReadKey();

        }
    }
}
