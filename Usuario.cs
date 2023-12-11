using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Alugamóvel
{
    internal class Usuario
    {
        internal int IdCliente { get; set; }
        internal string LoginCliente { get; set; }
        internal string SenhaCliente { get; set; }
        internal string NomeCliente { get; set; }
        internal string Endereco { get; set; }
        internal string Telefone { get; set; }
        internal string Email { get; set; }

        internal Usuario(int idCliente, string loginCliente, string senhaCliente, string nomeCliente, string endereço, string telefone, string email) 
        { 
            IdCliente = idCliente;
            LoginCliente = loginCliente;
            SenhaCliente = senhaCliente;
            NomeCliente = nomeCliente;
            Endereco = endereço; 
            Telefone = telefone;
            Email = email;
        }
        public void ListaUsuarios()
        {
            Console.WriteLine($"{NomeCliente}, {IdCliente}");
        }

        public void FazerReserva(DateTime dataInicio, DateTime dataFinal)
        {
            
        }
    }
}
