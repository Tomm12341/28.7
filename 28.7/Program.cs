using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prenotazione p = new Prenotazione();

            Cliente cliente = new Cliente();

            Console.WriteLine("Inserisci il tuo nome: ");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome: ");
            cliente.Cognome = Console.ReadLine();

            p.Dataprenotazione = DateTime.Today;

            DateTime riferimento = new DateTime();
            riferimento = DateTime.Today;

            p.Anno = riferimento.Year;

            Console.WriteLine("Che giorni verrai da noi?");

            Console.WriteLine("Dal: ");
            p.Dal = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Al: ");
            p.Al = DateTime.Parse(Console.ReadLine());

            TimeSpan T = p.Al - p.Dal;
            int temposoggiorno = T.Days;

            Camera c = new Camera();


            Console.WriteLine("Scegli la camera (singola o doppia): ");
            c.Tipologia = Console.ReadLine();
            bool tipo; //se è singola è true 

            if (c.Tipologia == "singola")
            {
                tipo = true;
            } else
            {
                tipo = false;
            }

            Console.WriteLine("Selezionare il tipo di trattamento(mezza pensione, pensione completa,pernottamento con prima colazione): ");
            c.Trattamento = Console.ReadLine();

            double e = 50;

            if (c.Trattamento == "mezza pensione")
            {
                e = e / 2;
            }
            else if (c.Trattamento == "pensione completa")
            {
                e = 50;
            } else
            {
                e = e / 3;
            }
            double Tariffatotale = 0;

            if (tipo == true)
            {
                Tariffatotale = e + 25;
            }
            else
                Tariffatotale = e + 50;

            Console.WriteLine(" premi invio per il riepilogo:\n");
            Console.WriteLine("prenotazione effettuata il:{0}",riferimento);




        }

        
        }
    }

