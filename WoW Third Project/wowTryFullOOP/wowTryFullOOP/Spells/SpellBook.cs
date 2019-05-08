using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class SpellBook
    {
        private List<ISpell> spellBook;

        public void AddSpell(ISpell spell)
        {
            spellBook.Add(spell);
        }

        public void ShowSpellInSpellBook()
        {
            foreach (var item in spellBook)
            {
                Console.WriteLine(item.Name);
            }
        }

    }
}
