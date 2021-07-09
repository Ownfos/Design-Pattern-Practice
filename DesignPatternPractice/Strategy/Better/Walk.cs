﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Strategy.Better
{
    public class Walk : IMoveStrategy
    {
        public void Move()
        {
            Console.WriteLine("Walking");
        }
    }
}
