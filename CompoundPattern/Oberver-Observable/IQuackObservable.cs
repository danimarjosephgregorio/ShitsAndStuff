﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundPattern
{
    public interface IQuackObservable
    {
        void RegisterObserver(IQuackObserver observer);
        void NotifyObservers();
    }
}