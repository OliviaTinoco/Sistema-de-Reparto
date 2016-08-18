using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
    public class clsrutamaps
    {
        public int iplan { get; set; }
        public int icodpedido { get; set; }
        public int icodcliente{ get; set; }
        public string savecte { get; set; }

        public string scallecte { get; set; }
        public string szonacte { get; set; }
        //public string snomcte { get; set; }
        public int icodemp { get; set; }
        //public string snomemp { get; set; }
        public string sestado { get; set; }
        public int icodfec { get; set; }

        public clsrutamaps() { }

        public clsrutamaps(int iplan, int icodp, int icodte, int icoemp, string save, string scalle, string szona /*string snom*/
            ,string sesta, /*string snomep,*/ int ifec)

        {
            this.icodpedido = icodp;
            this.icodcliente = icodte;
            this.savecte = save;
            this.scallecte = scalle;
            this.szonacte = szona;
            //this.snomcte = snom;
            //this.snomemp = snomep;
            this.sestado = sestado;
            this.icodemp = icodemp;
            this.iplan = iplan;
            this.icodfec = ifec;



        }
    }
}
