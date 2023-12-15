using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prenotazione p=new Prenotazione();
            
            Cliente cliente = new Cliente();

            Console.WriteLine("Inserisci il tuo nome: ");
           cliente.Nome= Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome: ");
            cliente.Cognome = Console.ReadLine();

            p.Dataprenotazione=DateTime.Today;

            DateTime riferimento = new DateTime();
         
           
            p.Anno = riferimento.Year;



           
        }
    }
}
