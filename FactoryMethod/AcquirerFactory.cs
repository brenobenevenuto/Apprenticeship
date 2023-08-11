﻿using FactoryMethod.Enums;
using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class AcquirerFactory
    {
        public abstract IAcquirer CreateAcquirer(EnumAcquirer enumAcquirer);
    }
}
