using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alugamóvel
{
    internal class Devolucao
    {
        internal bool Status { get; set; }

        public Devolucao(bool status)
        {
            Status = status;
        }

        public Devolucao()
        {
        }

        public DateTime DataDevolucao()
        {
            if (Status)
            {
                DateTime dataD = DateTime.Now;
                string formato = "dd/MM/yyyy HH:mm:ss";
                Console.WriteLine("Devolução registrada em: " + dataD.ToString(formato));
                return dataD;
            }           
            return DateTime.MinValue;
        }

        
    
        public void TornarDisponivel() 
        {

        }

    }
}
