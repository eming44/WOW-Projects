using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public interface ICoolDownable
    {
        int Ticks { get; }
        int Duration { get; }
    }
}
