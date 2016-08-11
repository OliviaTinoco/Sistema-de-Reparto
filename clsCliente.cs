using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
    public class clsCliente
    {
        public int id { get; set; }
        public string pnombre { get; set; }
        public string snombre { get; set; }
        public string papellido { get; set; }
        public string sapellido { get; set; }
        public string nit { get; set; }
        public string fecha_nac { get; set; }
        
        public clsCliente() { }

        public clsCliente(int pid, string nombre, string nombre2, string apellido, string apellido2, string pnit, string fecha)

        {
            this.id = pid;
            this.pnombre = nombre;
            this.snombre = nombre2;
            this.papellido = apellido;
            this.sapellido = apellido2;
            this.nit = pnit;
            this.fecha_nac = fecha;            
        }
    }
}
