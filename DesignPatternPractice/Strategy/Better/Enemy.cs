using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Strategy.Better
{
    public abstract class Enemy
    {
        protected IAttackStrategy attackStrategy;
        protected IMoveStrategy moveStrategy;

        public void Attack()
        {
            attackStrategy.Attack();
        }

        public void Move()
        {
            moveStrategy.Move();
        }
    }
}
