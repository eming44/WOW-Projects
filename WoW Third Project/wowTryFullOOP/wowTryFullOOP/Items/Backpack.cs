using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class Backpack : IBackpack<Item>

    {
        private IBackpackable<Item>[] backpack;
        //private T[] elements;


        public Backpack this[int index]
        {
            get
            {
                return (Backpack)this.backpack[index];
            }
            set
            {
                backpack[index] = value;
            }
        }



        public Backpack(int slots)
        {
            this.backpack = new Backpack[slots];
            //this.elements = new T[slots];
        }


        public void Add(IBackpackable<Item> item)
        {
            bool hasFreeSlots = false;
            for (int i = 0; i < backpack.Length; i++)
            {
                if (backpack[i] == null)
                {
                    backpack[i] = item;
                    hasFreeSlots = true;
                    break;
                }
            }
            if (hasFreeSlots == false)
            {
                Console.WriteLine("Backpack full");
            }
        }

        public void Change(IEquippable<Item> itemEquipped, IEquippable<Item> itemInBackpack, IHero hero)
        {
            IEquippable<Item> freeSlot;
            freeSlot = itemInBackpack;
            itemInBackpack = itemEquipped;
            hero.Equippment[freeSlot.SlotCompatibility] = null;
            hero.Equip(freeSlot);
           // itemEquipped = freeSlot;
        }

        public void ShowBackpack()
        {
            foreach (var item in this.backpack)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
