using FactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Interface
{
    public interface IAcquirer
    {
        public EnumAcquirer Acquirer { get; }
        public void ReadFile();
    }
}
