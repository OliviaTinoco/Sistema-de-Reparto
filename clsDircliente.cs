using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
    public class clsDircliente
    {
        //public int id { get; set; }
        public int idc { get; set; }
        public string zona { get; set; }
        public string calle { get; set; }
        public string avenida { get; set; }
        
        public clsDircliente() { }

        public clsDircliente(int pidc, string zone, string street, string aven)

        {
            //this.id = pid;
            this.idc = pidc;
            this.zona = zone;
            this.calle = street;
            this.avenida = aven;
        }
    }
}
