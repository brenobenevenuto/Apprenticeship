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

        /// <summary>
        ///     Informação que todas as adquirentes devem implementar, identificação.
        /// </summary>
        public EnumAcquirer Acquirer { get; }

        /// <summary>
        ///     Metodo de leitura de arquivo onde todas as adquirentes devem implementar.
        /// </summary>
        public void ReadFile();
    }
}
