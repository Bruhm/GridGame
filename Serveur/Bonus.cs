using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur
{
    public class Bonus : Cases
    {
        public Bonus(int i, int j) : base (i,  j)
    {
            PeutEtreEcraser = true;

        }
    }
}
