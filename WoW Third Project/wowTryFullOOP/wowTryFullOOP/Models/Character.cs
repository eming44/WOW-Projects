using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace wowTryFullOOP
{
    public abstract class Character : ICharacter
    {
        #region Stats Fields
        private string name;
        //private List<ISpell> spellBook;
        //Health-----------------------------
        private double healthCurr;
        private double healthCap;
        private double healthRegen = 1.5;
        private Timer healthRegenTimer = new Timer();
        //Power stats------------------------
        private IPower power;
        //Defence stats----------------------
        private double armor;
        private double spellResistance;
        private int missChance;
        //Offence stats----------------------
        private int damage;
        private int criticalChance = 15;
        private double criticalDamage = 20;
        //LevelUP & Experience---------------
        private int level = 1;
        private double levelMultiplier = 1.35;
        private int experienceCurr = 0;
        private int experienceCap = 250;
        private bool isAlive;
        private string classKind;
        //Spells------------------------------
        private List<ISpell> spellBook = new List<ISpell>();
        #endregion
        #region Properties
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        //Health-----------------------------
        public double HealthCurr
        {
            get
            {
                return this.healthCurr;
            }
            set
            {
                this.healthCurr = value;
            }
        }
        public double HealthCap
        {
            get
            {
                return this.healthCap;
            }
            set
            {
                this.healthCap = value;
            }
        }
        public Timer HealthRegenTimer
        {
            get
            {
                return this.healthRegenTimer;
            }
            set
            {
                this.healthRegenTimer = value;
            }
        }
        public double HealthRegen
        {
            get
            {
                return this.healthRegen;
            }
            set
            {
                this.healthRegen = value;
            }
        }
        //Power stats------------------------
        public IPower Power
        {
            get
            {
                return this.power;
            }
            set
            {
                this.power = value;
            }
        }
        //Defence stats----------------------
        public double Armor
        {
            get
            {
                return this.armor;
            }
            set
            {
                this.armor = value;
            }
        }
        public double SpellResistance
        {
            get
            {
                return this.spellResistance;
            }
            set
            {
                this.spellResistance = value;
            }
        }
        public int MissChance
        {
            get
            {
                return this.missChance;
            }
            set
            {
                this.missChance = value;
            }
        }
        //Offence stats----------------------
        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }
        public int CriticalChance
        {
            get
            {
                return this.criticalChance;
            }
            set
            {
                this.criticalChance = value;
            }
        }
        public double CriticalDamage
        {
            get
            {
                return this.criticalDamage;
            }
            set
            {
                this.criticalDamage = value;
            }
        }
        //LevelUP & Experience---------------
        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }
        public string ClassKind
        {
            get
            {
                return this.classKind;
            }
            set
            {
                this.classKind = value;
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }
        //Spels------------------------------
        public List<ISpell> SpellBook
        {
            get
            {
                return this.spellBook;
            }
            set
            {
                this.spellBook = value;
            }
        }

        #endregion
        #region Constructors
        public Character(
            string name,
            double healthCap,
            IPower power,
            double armor,
            double spellResistanceCurr,
            int damage,
            int experienceCap)
        {
            this.name = name;
            this.healthCurr = healthCap;
            this.healthCap = healthCap;
            this.power = power;
            this.armor = armor;
            this.spellResistance = spellResistanceCurr;
            this.missChance = 5;
            this.damage = damage;
            this.level = 1;
            this.experienceCurr = 0;
            this.experienceCap = experienceCap;
            this.isAlive = true;
            InitHealthRegenTimer();
        }
        #endregion
        #region Methods
        //Attack--------------------------
        public void Attack(ICharacter attacked)
        {
            try
            {
                if (CheckMultiCast.CheckUsabilityAttack(this, attacked) == true)
                {
                    Random rnd = new Random();
                    int randomDamage = rnd.Next(this.damage - 10, this.damage);
                    if (attacked.HealthCurr == attacked.HealthCap)
                    {
                        attacked.HealthRegenTimer.Start();
                    }
                    double calDamage = (randomDamage + CalCriticalChance()) - (0.7 * this.armor);
                    if (calDamage < 0)
                    {
                        calDamage = 0;
                    }
                    attacked.HealthCurr -= calDamage;
                    attacked.Armor -= 0.1 * (calDamage++);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException) { }
        }
        private int CalCriticalChance()
        {
            Random rnd = new Random();
            int randomChance = rnd.Next(0, 100);
            if (randomChance >= 0 && randomChance <= this.criticalChance)
            {
                return CalCriticalDamage();
            }
            else
            {
                return 0;
            }
        }
        private int CalCriticalDamage()
        {
            Random rnd = new Random();
            int randomDamage = rnd.Next(Convert.ToInt32(2 * this.levelMultiplier), Convert.ToInt32(this.criticalDamage* this.levelMultiplier));
            return randomDamage;
        }
        protected void Cast(ISpellCast spell)
        {
            try
            {
                if (Check.IsAlive(this) == true)
                {
                    SpellLevelUp(spell, this.level);
                    spell.Cast(this);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException) { }
        }
        protected void CastTo(ISpellCastTo spell, ICharacter target)
        {
            try
            {
                if (Check.IsAlive(this) == true)
                {
                    SpellLevelUp(spell, this.level);
                    spell.CastTo(this, target);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException) { }
        }
        //Regeneration--------------------
        private void InitHealthRegenTimer()
        {
            //Timer t = new Timer();
            healthRegenTimer.Elapsed += new ElapsedEventHandler(healthRegen_Tick);
            healthRegenTimer.Interval = new TimeSpan(0, 0, 1).TotalMilliseconds;
            healthRegenTimer.Start();
        }
        private void healthRegen_Tick(object sender, ElapsedEventArgs e)
        {
            if (this.healthCurr < this.healthCap && this.healthCurr > 0)
            {
                this.healthCurr += this.healthRegen;
                if (this.healthCurr > this.healthCap)
                {
                    this.healthCurr = this.healthCap;
                    healthRegenTimer.Stop();
                }
            }
        }
        //Experience & LevelUP------------
        private void ObtainExperince(int experince)
        {
            this.experienceCurr += experince;
            if (this.experienceCurr > this.experienceCap)
            {
                this.experienceCurr = 0;
                this.experienceCap *= 2;
                this.Levelup();
            }
        }
        private void Levelup()
        {
            this.level++;
            this.healthCap += (100 * this.levelMultiplier);
            this.healthCurr = this.healthCap;
            this.healthRegen += this.levelMultiplier;
            this.armor += (50 * this.levelMultiplier);
            this.spellResistance += (50 * this.levelMultiplier);
            this.damage += (20 * Convert.ToInt32(this.levelMultiplier));
            this.levelMultiplier *= 2;
        }
        private void SpellLevelUp(ISpell spell, int level)
        {
            spell.Value *= level;
        }
        #endregion
    }
}
