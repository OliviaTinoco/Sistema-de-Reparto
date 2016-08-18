using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
    public class clsProducto
    {
        public int icod { get; set; }
        public int icodprov { get; set; }
        public int icodexist { get; set; }

        public string sdesc { get; set; }
        public string smarc { get; set; }
        public string snom { get; set; }


        public clsProducto() { }

        public clsProducto(int icodi, int icodprov, int icodex, string sno, string sdesc, string smarc)

        {
            this.icod = icodi;
            this.icodprov = icodprov;
            this.icodexist = icodex;
            this.sdesc = sdesc;
            this.snom = sno;
            this.smarc = smarc;




        }
    }
}
