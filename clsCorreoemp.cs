using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
    public class clsCorreoemp
    {
        //public int id { get; set; }
        public int ide { get; set; }
        public string correo { get; set; }

        public clsCorreoemp() { }

        public clsCorreoemp(int pide, string pmail)

        {
            //this.id = pid;
            this.ide = pide;
            this.correo = pmail;
        }
    }
}
