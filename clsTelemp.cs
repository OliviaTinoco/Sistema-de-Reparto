using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
    public class clsTelemp
    {
        //public int id { get; set; }
        public int ide { get; set; }
        public string telefono { get; set; }

        public clsTelemp() { }

        public clsTelemp(int pide, string ptel)

        {
            //this.id = pid;
            this.ide = pide;
            this.telefono = ptel;
        }
    }
}
