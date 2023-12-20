using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._7
{
    internal class Prenotazione
    {
        public DateTime Dataprenotazione { get; set; }
        public float Anno { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
        public float Caparra { get; set; }
        public float Tariffa { get; set; }
        public Cliente ClienteP {  get ; set; }
    
        public Camera CameraP { get; set; }
        public List<Serviziaggiuntivi> Serviziplus { get; set; }

    }
}
