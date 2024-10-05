using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public enum Rarity
    {
        Common = 1,
        Uncommon = 2,
        Rare = 3,
        Epic = 5
    }

    internal class Weapon
    {
        public string Name { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Sockets { get; set; }

        private Rarity rarity;
        private Gem[] gems;

        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }


        public void AddGem(int index, Gem gem)
        {
            if (index >= Sockets) throw new ArgumentException("Index is our of range");
            else
            {
                gems[index] = gem;
                this.Strength += gem.Strength;
                this.Agility += gem.Agility;
                this.Vitality += gem.Vitality;

                this.MinDamage += gem.Strength * 2;
                this.MaxDamage += gem.Strength * 3;

                this.MinDamage += gem.Agility * 1;
                this.MaxDamage += gem.Agility * 4;
            }
        }

        public override string ToString()
        {
            return $"{Name}: {MinDamage}-{MaxDamage} Damage, +{Strength} Strength, +{Agility} Agility, +{Vitality} Vitality";
        }
    }
}
