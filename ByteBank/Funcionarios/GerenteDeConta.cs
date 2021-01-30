using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticar
    {
       
        //public string Senha { get; set; }

        public GerenteDeConta(string cpf) : base(5000, cpf)
        {

        }
        // public bool Autenticar(string senha)
        // {
        //     return this.Senha == senha;

        // }
        public override void AumentarSalario()
        {
            Salario = Salario * 1.5;
        }

        public override double GetObterBonificacao()
        {

            return Salario * 0.5;
        }
    }
}