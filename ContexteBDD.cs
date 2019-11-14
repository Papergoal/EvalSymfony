using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temporaire
{
    class ContexteBDD : DbContext
    {

        public ContexteBDD()
            :base ("ChaineDeConnection")
        {
            
        }
    }
}
