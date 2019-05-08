using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace wowTryFullOOP
{
    public class SpellCoolDown : ICoolDownable
    {
        private Timer spellCoolDownTimer = new Timer();
        private int ticks;
        private int duration;

        public int Ticks
        {
            get
            {
                return this.ticks;
            }
        }
        public int Duration
        {
            get
            {
                return this.duration;
            }
        }

        public SpellCoolDown(int duration)
        {
            this.duration = duration;
            InitCoolDownTimer();
        }

        public void InitCoolDownTimer()
        {
            spellCoolDownTimer.Elapsed += new ElapsedEventHandler(SpellCoolDown_Tick);
            spellCoolDownTimer.Interval = new TimeSpan(0, 0, 1).TotalMilliseconds;
            spellCoolDownTimer.Start();

        }
        private void SpellCoolDown_Tick(object sender, ElapsedEventArgs e)
        {
            this.ticks++;
            if (ticks == this.duration)
            {
                spellCoolDownTimer.Stop();
                ticks = 0;
            }
        }
    }
}
