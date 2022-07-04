﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcologicalModel
{
    public abstract class Cell
    {
        protected readonly Ocean ocean;

        public Cell(Ocean ocean)
        {
            this.ocean = ocean;
        }

        public abstract char GetSymbol();
        public abstract void Iterate(int i, int j);
    }
}
