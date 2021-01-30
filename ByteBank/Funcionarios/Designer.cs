namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer( string cpf) : base(400, cpf)
        {

        }

         public override void AumentarSalario()
        {
            Salario = Salario * 1.05;
        }

        public override double GetObterBonificacao()
        {
            return Salario * 0.25;
        }
    }
}