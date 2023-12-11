namespace Alugamóvel

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Agencia
            Agencia agencia = new Agencia();
            agencia.AdicionarFuncionario(new Staff(1, "Amanda", "Gerente", 1000, "amandab", "1234"));
            agencia.ListagemFuncionarios();

            //Staff
            Devolucao devolucao = new Devolucao();
            Staff staff = new Staff();

            devolucao.Status = true;
            DateTime dataDevolucao = devolucao.DataDevolucao();
            staff.RegistrarUsuario(new Usuario(2, "amandab", "senha", "nomecliente", "endereço", "telefone", "email"));
            staff.ListagemUsuarios();
            //staff.AtualizarDataManutencao("dd/MM/AA");

            //Usuario










        }
    }
}
