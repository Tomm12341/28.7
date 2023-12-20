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

            Console.WriteLine("Inserisci il tuo nome: ");
            p.ClienteP.Nome =Console.ReadLine();

            Console.WriteLine("Inserisci il tuo cognome: ");
            p.ClienteP.Cognome=Console.ReadLine();

            Console.WriteLine("Inserisci il tuo codice fiscale: ");
            p.ClienteP.Codicefiscale = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo numero di telefono: ");
            p.ClienteP.Numerotelefono = Console.ReadLine();
            
            Console.WriteLine("Inserisci la tua email: ");
            p.ClienteP.Email= Console.ReadLine();

            Console.WriteLine("Inserisci la tua città: ");
            p.ClienteP.Citta = Console.ReadLine();
            
            Console.WriteLine("Inserisci la tua provincia: ");
            p.ClienteP.Email = Console.ReadLine();

            p.Dataprenotazione = DateTime.Now;

            p.Anno = p.Dataprenotazione.Year;

            Console.WriteLine("Da: ");
            p.Dal = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Al: ");
            p.Al = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Selezionare il tipop di camera (singola o doppia): ");
            p.CameraP.Tipologia= Console.ReadLine();

            Console.WriteLine("Inserire il tipo di trattamento(pensione completa, mezza pensione, pernottamento con prima colazione): ");
            p.CameraP.Trattamento = Console.ReadLine();

           Serviziaggiuntivi Colazioneincamera=new Serviziaggiuntivi();

            Colazioneincamera.Data = p.Al;
           
            if (p.CameraP.Tipologia == "singola")
            {
                Colazioneincamera.Quantita = 1;
            }
            else
                Colazioneincamera.Quantita = 2;

            Colazioneincamera.Prezzo = 10;

            Colazioneincamera.Descrizione = "Si può scegliere tra una colazione salata a base di salumi e una dolce con caffè e brioche ";

            p.Serviziplus.Add(Colazioneincamera);

            Console.WriteLine("Nome: {0}\n Cognome: {1}\n Email: {2\n Dal: {3}\n Al: {4}\n Tipologia: {5}\n Trattamento: {6}\n Servizi aggiuntivi: {7}", p.ClienteP.Nome, p.ClienteP.Cognome, p.ClienteP.Email, p.Dal, p.Al, p.CameraP.Tipologia, p.CameraP.Trattamento,p.Serviziplus);
            
        }

        
        }
    }

