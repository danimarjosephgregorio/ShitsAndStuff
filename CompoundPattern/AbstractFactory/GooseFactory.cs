﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public class GooseFactory : AbstractGooseFactory
    {
        public override Goose CreateGoose()
        {
            return new Goose();
        }
    }
}
