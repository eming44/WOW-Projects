using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public interface IClassStats
    {
        int Value { get; set; }

        void Buff(IHero hero, int stat);
    }
}
