using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public interface IPlate : IEquippable<Item>
    {
        int Plate { get; }
    }
}
