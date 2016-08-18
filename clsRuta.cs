using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
   public class clsRuta //Clase publica, para manejar ruta
    {
        public int icod { get; set; } 
       
        public string szona { get; set; }
        public string sdecripcion { get; set; }
       

        public clsRuta() { }

        public clsRuta(int icodi, string szon, string sdesc)

        {
            this.icod = icodi;

            this.szona = szon;
            this.sdecripcion = sdesc;


        }
    }
}
