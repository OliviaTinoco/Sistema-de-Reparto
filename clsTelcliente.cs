using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
    class clsTelcliente
    {
        //public int id { get; set; }
        public int idc { get; set; }
        public string telefono { get; set; }

        public clsTelcliente() { }

        public clsTelcliente(int pidc, string ptel)

        {
            //this.id = pid;
            this.idc = pidc;
            this.telefono = ptel;
        }
    }
}
