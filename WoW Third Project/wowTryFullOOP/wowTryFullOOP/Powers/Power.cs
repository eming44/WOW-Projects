using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public abstract class Power : IPower
    {
        private string powerName;
        private double powerCurr;
        private double powerCap;

        public string PowerName
        {
            get
            {
                return this.powerName;
            }
        }
        public double PowerCurr
        {
            get
            {
                return this.powerCurr;
            }
            set
            {
                this.powerCurr = value;
            }
        }
        public double PowerCap
        {
            get
            {
                return this.powerCap;
            }
            set
            {
                this.powerCap = value;
            }
        }

        public Power(
            string powerName, 
            double powerCurr, 
            double powerCapp)
        {
            this.powerName = powerName;
            this.powerCurr = powerCurr;
            this.powerCap = powerCapp;
        }

        public virtual void PowerConsume(ISpell spell)
        {
            if (this.powerCurr >= spell.PowerCost)
            {
                this.powerCurr -= spell.PowerCost; 
            } 
            else
            {
                Console.WriteLine($"I don't have enought { this.powerName }.");
                throw new OperationCanceledException();
            }
        }
        public virtual void PowerGenerate(ISpell spell)
        {
            if (PowerCurr < PowerCap)
            {
                PowerCurr += spell.PowerCost;
                if (PowerCurr > PowerCap)
                {
                    PowerCurr = PowerCap;
                }
            }
        }
    }
}
