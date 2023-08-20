using FactoryMethod.Enums;
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
        /// <summary>
        ///     (Fabrica) Metodo que vai retornar a instancia correta 
        /// </summary>
        /// <param name="enumAcquirer"></param>
        /// <returns></returns>
        public abstract IAcquirer CreateAcquirer(EnumAcquirer enumAcquirer);
    }
}
