
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace wowTryFullOOP
{
    public class ManaPower : Power, IPower
    {
        private double powerRegen = 1.5;
        Timer powerRegenTimer = new Timer();

        public ManaPower(double powerCapp) : base("Mana", powerCapp, powerCapp)
        {
        }

        private void InitPowerRegenTimer()
        {
            powerRegenTimer.Elapsed += new ElapsedEventHandler(powerRegen_Tick);
            powerRegenTimer.Interval = new TimeSpan(0, 0, 1).TotalMilliseconds;
            powerRegenTimer.Start();
        }
        private void powerRegen_Tick(object sender, ElapsedEventArgs e)
        {
            if (base.PowerCurr < base.PowerCap && base.PowerCurr > 0)
            {
                base.PowerCurr += this.powerRegen;
                if (base.PowerCurr > base.PowerCap)
                {
                    base.PowerCurr = base.PowerCap;
                    powerRegenTimer.Stop();
                }
            }
        }
        public override void PowerConsume(ISpell spell)
        {
            base.PowerConsume(spell);
            if (base.PowerCurr != base.PowerCap)
            {
                this.powerRegenTimer.Start();
            }
        }
    }
}
