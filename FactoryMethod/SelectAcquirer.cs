using FactoryMethod.Enums;
using FactoryMethod.Interface;
using FactoryMethod.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SelectAcquirer : AcquirerFactory
    {
        public override IAcquirer CreateAcquirer(EnumAcquirer enumAcquirer)
        {
            switch (enumAcquirer) 
            {
                case EnumAcquirer.Cielo:
                    return new CieloAcquirer();
                case EnumAcquirer.Rede:
                    return new RedeAcquirer();
                case EnumAcquirer.GetNet:
                    return new GetNetAcquirer();
                default:
                    throw new ArgumentException("Nao Existe esta adquirente.");
            }
        }
    }
}
