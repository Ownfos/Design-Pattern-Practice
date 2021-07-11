using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Decorator.Better
{
    public class Resistant : EnemyDecorator
    {
        public Resistant(Enemy enemy) : base(enemy)
        {
               
        }

        public override void Attack()
        {
            enemy.Attack();
        }

        public override int GetATK()
        {
            return enemy.GetATK();
        }

        public override int GetHP()
        {
            return enemy.GetHP() * 2;
        }

        public override string GetName()
        {
            return $"Resistant {enemy.GetName()}";
        }
    }
}
