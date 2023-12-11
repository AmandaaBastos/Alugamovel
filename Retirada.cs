using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alugamóvel
{
    internal class Retirada
    {
        bool Saida { get; set; }
        bool Pagamento { get; set; }

        internal Retirada(bool saida, bool pagamento)
        {
            Saida = saida;
            Pagamento = pagamento;
        }

        public void DataRetirada()
        {

        }

        public void TornarIndisponivel()
        {

        }

    }
}
