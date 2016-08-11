using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
    public class ClsExistencia
    {
        public int icod { get; set; }
        public int icantidad { get; set; }
        public int iprecompra { get; set; }
        public int ipreventa { get; set; }
        public int icodubi { get; set; }


        public ClsExistencia() { }

        public ClsExistencia(int icodi, int ican, int ipcom, int iprev, int icoubi)

        {
            this.icod = icodi;
            this.icantidad = ican;
            this.iprecompra = ipcom;
            this.ipreventa = iprev;
            this.icodubi = icoubi;

       


        }
    }
}
