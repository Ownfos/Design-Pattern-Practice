using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Decorator.Naive
{
    public class Archer : Enemy
    {
        public Archer(bool isResistant, bool isPowerful, bool isElite)
        {
            name = "Archer";
            baseHP = 100;
            baseATK = 20;
            this.isResistant = isResistant;
            this.isPowerful = isPowerful;
            this.isElite = isElite;
        }

        public override void Attack()
        {
            Console.WriteLine("Shooting arrows");
        }
    }
}
