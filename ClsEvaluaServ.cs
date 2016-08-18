using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemareparto
{
    public class ClsEvaluaServ
    {
        public int id { get; set; }
        public string pnombre { get; set; }
        public string snombre { get; set; }
        public string pfecha { get; set; }
        public string sobsv { get; set; }
        public string scalientrega { get; set; }
        public string scaliserv { get; set; }

        public ClsEvaluaServ() { }

        public ClsEvaluaServ(int pid, string snom, string sfec, string sobv, string scalie, string scaliserv)

        {
            this.id = pid;
            this.pnombre = snom;
            this.pfecha = sfec;
            this.sobsv = sobsv;
            this.scalientrega = scalie;
            this.scaliserv = scaliserv;
        }

    }
}
