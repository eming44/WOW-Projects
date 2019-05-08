using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class RagePower : Power, IPower
    {
        public RagePower() : base("Rage", 0, 100)
        {
        }
    }
}
