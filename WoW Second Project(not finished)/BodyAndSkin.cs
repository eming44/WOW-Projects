using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class BodyAndSkin
    {
        private SkinColor skinColor;
        private BodyType bodyType;
        public SkinColor SkinColorGetSet
        {
            get
            {
                return this.skinColor;
            }
            set
            {
                this.skinColor = value;
            }
        }
        public BodyType BodyTypeGetSet
        {
            get
            {
                return this.bodyType;
            }
            set
            {
                this.bodyType = value;
            }
        }
        public enum SkinColor
        {
            Light,
            Medium,
            Tan,
            Dark,
            Green,
            Purple,
            Pink,
            Blue,
            Red
        }
        public enum BodyType
        {
            Skinny,
            Slim,
            Muscular,
            Fat
        }
        public BodyAndSkin(
            SkinColor newSkinColor,
            BodyType newBodyType)
        {
            this.skinColor = newSkinColor;
            this.bodyType = newBodyType;
        }
    }
}
