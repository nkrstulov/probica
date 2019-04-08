using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19G3
{
    class Iznimka :ApplicationException
    {
        public string Poruka { get; set; }
        public Iznimka(string poruka)
        {
            Poruka = poruka;
        }

    }
}
