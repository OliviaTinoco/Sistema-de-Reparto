using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
   public class clsUbicacion
    {
        public int icod { get; set; }
        public int icodbod { get; set; }

        public string spasillo { get; set; }
        public string sestante { get; set; }
        public string sslot { get; set; }


        public clsUbicacion() { }

        public clsUbicacion(int icodi, int icodbod,string spas, string sesta, string slot)

        {
            this.icod = icodi;
            this.icodbod = icodbod;
            this.spasillo = spas;
            this.sestante = sesta;
            this.sslot = slot;

           


        }
    }
}
