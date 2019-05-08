using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public interface IEquippable<T> : IItem, IBackpackable<Item>
    {
        int SlotCompatibility { get; set; }
        int Value { get; set; }
        int Stragiht { get; set; }
        int Agility { get; set; }
        int Intellect { get; set; }

        void Equip(IHero hero);
        void UnEquip(IHero hero);
    }
}
