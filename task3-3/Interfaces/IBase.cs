﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    public interface IBase : IPrinter
    {
        double FindAverage();

        void Refill(bool userInput = false);
    }
}
