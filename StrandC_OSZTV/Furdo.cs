using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrandC_OSZTV
{
    public class Furdo
    {
        public string Nev { get; private set; }
        public string Cim { get; private set; }
        public int Ar { get; private set; }
        public int VizHofok { get; private set; }

        public Furdo(string nev, string cim, int ar, int vizHofok)
        {
            Nev = nev;
            Cim = cim;
            Ar = ar;
            VizHofok = vizHofok;
        }
        public Furdo(string sor)
        {
            string[] temp=sor.Split(';');
            Nev = temp[0];
            Cim = temp[1];
            Ar = int.Parse(temp[2]);
            VizHofok = int.Parse(temp[3]);
        }
        public string IRSZ()
        {
            return Cim.Split(' ')[0];
        }
        public string Telepules()
        {
            
                return Cim.Split(' ')[1].TrimEnd(',');
            
            
        }
    }
}
