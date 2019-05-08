using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Hair
    {
        private HairColor hairColor;
        private HairStyle hairStyle;
        public HairColor HairColorGetSet
        {
            get
            {
                return this.hairColor;
            }
            set
            {
                this.hairColor = value;
            }
        }
        public HairStyle HaorStyleGetSet
        {
            get
            {
                return this.hairStyle;
            }
            set
            {
                this.hairStyle = value;
            }
        }
        public enum HairStyle
        {
            Short,
            Medium,
            Long
        }
        public enum HairColor
        {
            Blonde,
            Brunette,
            Red,
            Black,
            White,
            Ginger
        }
        public Hair(
            HairColor newHairColor,
            HairStyle newHairStyle)
        {
            this.hairColor = newHairColor;
            this.hairStyle = newHairStyle;
        }
    }
}
