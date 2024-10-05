using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Gem
    {
        public int Strength { get; }
        public int Agility { get; }
        public int Vitality { get; }

        public Gem(string clarity, int strength, int agility, int vitality)
        {
            int modifier = 0;
            if (clarity == "Chipped") modifier = 1;
            else if (clarity == "Regular") modifier = 2;
            else if (clarity == "Perfect") modifier = 3;
            else if (clarity == "Flawless") modifier = 10;
            Strength = strength + modifier;
            Agility = agility + modifier;
            Vitality = vitality + modifier;
        }

        public Gem() { }
    }
}