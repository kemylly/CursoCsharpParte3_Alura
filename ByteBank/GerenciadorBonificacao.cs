using ByteBank.Funcionarios;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetObterBonificacao();
        }
        // public void Registrar(Diretor diretor)
        // {
        //     _totalBonificacao += diretor.GetObterBonificacao();
        // }
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}