using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alugamóvel
{
    internal class Reserva
    {
        bool StatusReserva { get; set; }
        int IdReserva { get; set; }
        string DataInicio { get; set; }
        string DataFinal { get; set;}
        double ValorTotal { get; set; }
        

        internal Reserva( bool statusReserva, int idReserva, string veiculo, string dataInicio, string dataFinal, double valorTotal)
        {
            StatusReserva = statusReserva;
            IdReserva = idReserva;
            DataInicio = dataInicio;
            DataFinal = dataFinal;
            ValorTotal = valorTotal;
            
        }
    }
}
