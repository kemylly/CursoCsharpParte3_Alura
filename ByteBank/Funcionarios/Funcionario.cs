using System;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario // colocar abstract para nao deixar um do tipo direto funcionario
    {
        //private int tipo; //0 = funcionario/ 1 = diretor / 2 = designer /
        public static int TotalDeFuncionarios { get; private set; } 
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }  //usando modificador de acesso

        // public Funcionario (int tipo)
        // {
        //     this.tipo = tipo;
        // }

        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
        //public abstract virtual void AumentarSalario()
        // {
        //     Salario = Salario + (Salario * 0.1);
        //     //Salario =  Salario * 1.1;
        //     //Salario*= 1.1;
        // }

        public abstract double GetObterBonificacao();
        //public abstract virtual double GetObterBonificacao()
        // {
        //     return Salario * 0.10;
        // }
    }
}