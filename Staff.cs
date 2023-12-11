using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Alugamóvel
{
    internal class Staff
    {
        internal int Id { get; set; }
        internal string Nome { get; set; }
        internal string Cargo { get; set; }
        internal double Salario { get; set; }
        internal string Login { get; set; }
        internal string Senha { get; set; }


        internal Staff(int id, string nome, string cargo, int salario, string login, string senha)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
            Login = login;
            Senha = senha;
        }
        public void ListaFuncionarios()
        {
            Console.WriteLine($"{Nome}, {Cargo}");
        }

        internal Devolucao devolucao = new Devolucao();
        public Staff(Devolucao devolucao)
        {
            this.devolucao = devolucao;
        }



        internal List<Usuario> usuarios;
        public Staff() { usuarios = new List<Usuario>(); }

        public void RegistrarUsuario(Usuario novoUsuario)
        {
            usuarios.Add(novoUsuario);
        }
        public void ListagemUsuarios()
        {
            foreach (var i in usuarios)
            {
                i.ListaUsuarios();
            }
        }


        //internal Carros carros = new Carros();
        //internal void AtualizarDataManutencao(string novaData)
        //{
        //    carros.AttManutencao(novaData);
        //    Console.WriteLine($"A data de manutenção foi atualizada para {novaData}.");
        //}

    }
}
