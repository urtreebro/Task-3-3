﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_4
{
    interface IOneDimensional : IBase
    {
        int[] GetArrayAbs100();

        int[] GetArrayWithoutDuplicates();
    }
}
