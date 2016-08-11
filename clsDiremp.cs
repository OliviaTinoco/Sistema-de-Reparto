using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
    public class clsDiremp
    {
        //public int id { get; set; }
        public int ide { get; set; }
        public string zona { get; set; }
        public string calle { get; set; }
        public string avenida { get; set; }

        public clsDiremp() { }

        public clsDiremp(int pide, string zone, string street, string aven)

        {
            //this.id = pid;
            this.ide = pide;
            this.zona = zone;
            this.calle = street;
            this.avenida = aven;
        }
    }
}
