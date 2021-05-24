using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolletta
{
    class Program
    {
        static void Main(string[] args)
        {

            // Realizzare un’applicazione console che consenta di eseguire il calcolo della bolletta della luce.
            // Si richiede di sviluppare un menù attraverso cui l’utente può scegliere di:
            // - inserire i propri dati(nome, cognome e kwH consumati);
            // - richiedere il calcolo del costo della bolletta che è costituito da una quota fissa di 40€ più il prodotto tra i kwH e 10.
            // - stampare a video i valori della bolletta, inclusi nome, cognome e costo pagato.
            // Ciascuna delle operazioni descritte sopra dovrà essere implementata attraverso una opportuna routine.

            string nome = "";
            string cognome = "";
            double consumo = 0;
            decimal costo = 0;
            const decimal Quota = 40;
            bool uscita = false;
            
            do
            
            {
                Console.WriteLine("Scegli A, B, C, D");
                switch (Console.ReadKey().KeyChar)
                {
                    case 'A': InserisciDati(out nome, out cognome, out consumo); break;
                    case 'B': CalcoloCostoBolletta(consumo, Quota, out costo); break;
                    case 'C': StampaDati(nome, cognome, costo); break;
                    case 'D': uscita=true; break;
                }
            } while (!uscita);

        }



        private static void StampaDati(string nome, string cognome, decimal costo)
        {
            Console.WriteLine($"Il tuo nome è: {nome}, il tuo cognome è: {cognome} e spendi: {costo}");
        }

        private static void CalcoloCostoBolletta(double consumo, decimal Quota, out decimal costo)
        {
           double prodotto = consumo * 10 ;
           costo = (decimal)prodotto + Quota;
           Console.WriteLine("Fatto");
        }

        private static void InserisciDati(out string a, out string b ,out double c)
        {
            

            do
            {
                Console.WriteLine("Inserisci il tuo nome:");
                a = Console.ReadLine();
                Console.WriteLine("Inserisci il tuo cognome:");
                b = Console.ReadLine();
                Console.WriteLine("Inserisci il tuo consumo:");
                c = double.Parse(Console.ReadLine());
            } while (a == "" || b == "" || c <= 0);
            
        }
    }
}
