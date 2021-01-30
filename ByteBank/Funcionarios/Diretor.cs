using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticar //primeiro a classe depois as interfaces
    {
        //public string Senha { get; set; }
        public Diretor(string cpf) : base(5000, cpf)
        {
            
        }

         public override void AumentarSalario()
        {
            Salario = Salario * 1.5;
        }

        public override double GetObterBonificacao()
        {
            //fazendo referencia para menbros da nossa clase base: base.OqueEuQuero
            //return Salario + base.GetObterBonificacao();
            return Salario * 0.5;
        }

        // public bool Autenticar(string senha)
        // {
        //     return this.Senha == senha;
            
        // }
    }
}