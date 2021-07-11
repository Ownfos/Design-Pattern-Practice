using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Decorator.Naive
{
    public abstract class Enemy
    {
        protected string name;

        // Base stats
        protected int baseHP;
        protected int baseATK;

        // Attributes for special enemies
        protected bool isResistant; // A resistant enemy has double HP
        protected bool isPowerful; // A powerful enemy has double ATK
        protected bool isElite; // An elite enemy has additional 500 HP and 200 ATK (applied at last)

        public int GetHP()
        {
            int hp = baseHP;
            if (isResistant)
            {
                hp *= 2;
            }
            if(isElite)
            {
                hp += 500;
            }
            return hp;
        }

        public int GetATK()
        {
            int atk = baseATK;
            if (isPowerful)
            {
                atk *= 2;
            }
            if (isElite)
            {
                atk += 200;
            }
            return atk;
        }

        public string GetFullName()
        {
            string fullName = name;
            if (isResistant)
            {
                fullName = "Resistant " + fullName;
            }
            if (isPowerful)
            {
                fullName = "Powerful " + fullName;
            }
            if (isElite)
            {
                fullName = "Elite " + fullName;
            }
            return fullName;
        }

        public abstract void Attack();
    }
}
