using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Decorator.Better
{
    public class Elite : EnemyDecorator
    {
        public Elite(Enemy enemy) : base(enemy)
        {

        }

        public override void Attack()
        {
            enemy.Attack();
        }

        public override int GetATK()
        {
            return enemy.GetATK() + 200;
        }

        public override int GetHP()
        {
            return enemy.GetHP() + 500;
        }

        public override string GetName()
        {
            return $"Elite {enemy.GetName()}";
        }
    }
}
