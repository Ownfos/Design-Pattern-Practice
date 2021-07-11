using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Decorator.Naive
{
    public class Knight : Enemy
    {
        public Knight(bool isResistant, bool isPowerful, bool isElite)
        {
            name = "Knight";
            baseHP = 200;
            baseATK = 10;
            this.isResistant = isResistant;
            this.isPowerful = isPowerful;
            this.isElite = isElite;
        }

        public override void Attack()
        {
            Console.WriteLine("Swinging sword");
        }
    }
}
