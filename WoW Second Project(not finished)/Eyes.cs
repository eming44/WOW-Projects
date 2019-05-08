using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Eyes
    {
        private EyesColor eyesColor;
        private EyesOpen eyesOpen;
        public EyesColor EyesColorGetSet
        {
            get
            {
                return this.eyesColor;
            }
            set
            {
                this.eyesColor = value;
            }
        }
        public EyesOpen EyesOpenGetSet
        {
            get
            {
                return this.eyesOpen;
            }
            set
            {
                this.eyesOpen = value;
            }
        }
        public enum EyesColor
        {
            Brown,
            Blue,
            Green,
            Red
        }
        public enum EyesOpen
        {
            WideOpen,
            Normal,
            Sleepy

        }
        public Eyes(
            EyesColor newEyesColor,
            EyesOpen newEyesOpen)
        {
            this.eyesColor = newEyesColor;
            this.eyesOpen = newEyesOpen;
        }
    }
}
