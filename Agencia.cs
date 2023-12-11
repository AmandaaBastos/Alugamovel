using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Alugamóvel
{
    internal class Agencia
    {
        internal List<Staff> funcionarios;
        public Agencia() { funcionarios = new List<Staff>(); }

        public void AdicionarFuncionario(Staff novoFuncionario)
        {
            funcionarios.Add(novoFuncionario);
        }

        public void ListagemFuncionarios()
        {
            foreach (var i in funcionarios)
            {
                i.ListaFuncionarios();
            }
        }
    }
}
