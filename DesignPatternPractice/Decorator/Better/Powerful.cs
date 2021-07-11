using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Decorator.Better
{
    public class Powerful : EnemyDecorator
    {
        public Powerful(Enemy enemy) : base(enemy)
        {

        }

        public override void Attack()
        {
            enemy.Attack();
        }

        public override int GetATK()
        {
            return enemy.GetATK() * 2;
        }

        public override int GetHP()
        {
            return enemy.GetHP();
        }

        public override string GetName()
        {
            return $"Powerful {enemy.GetName()}";
        }
    }
}
