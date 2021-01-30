using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticar : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticar(double salario, string cpf) : base(salario, cpf)
        {
        }

        public bool Autenticar(string senha)
        {
           return Senha == senha;
        }
    }
}