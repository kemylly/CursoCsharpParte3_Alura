namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario = Salario * 1.1;
        }

        public override double GetObterBonificacao()
        {
            return Salario * 0.2;
        }
    }
}