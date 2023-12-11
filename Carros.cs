using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Alugamóvel
{
    internal class Carros
    {
        internal string Modelo { get; set; }
        internal string Placa { get; set; }
        internal int Ano { get; set; }
        internal double PrecoAluguel { get; set; }
        internal string Manutencao { get; set; }
        internal bool Devolucao { get; set; }

        public Carros(string manutencao, bool devolucao, string modelo, string placa, double precoAluguel)
        {
            Manutencao = manutencao;
            Devolucao = devolucao;
            PrecoAluguel = precoAluguel;
        }


        internal void AttManutencao(string novaData)
        {
            Manutencao = novaData;
        }

        internal void ListarCarrosDisponiveis()
        {

        }
    }
}
