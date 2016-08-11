using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
    public class clsEmpleado
    {       
        public int id { get; set; }
        public int idp { get; set; }        
        public string pnombre { get; set; }
        public string snombre { get; set; }
        public string papellido { get; set; }
        public string sapellido { get; set; }            
        public string fecha_nac { get; set; }
        public string nit { get; set; }
        public string sueldo { get; set; }
        public string estado { get; set; }

        public clsEmpleado() { }

        public clsEmpleado(int pid, int pidp, string nombre, string nombre2, string apellido, string apellido2, string fecha, string pnit, string psueldo, string pestado)

        {
            this.id = pid;
            this.idp = pidp;
            this.pnombre = nombre;
            this.snombre = nombre2;
            this.papellido = apellido;
            this.sapellido = apellido2;            
            this.fecha_nac = fecha;
            this.nit = pnit;
            this.sueldo = psueldo;
            this.estado = pestado;
        }       
    }
}
