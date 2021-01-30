using System;
using ByteBank.Funcionarios;
//using ByteBank.Sistemas;
using KYCS.My_Private_Documents.Formacao_CSharp.formacaocsharp.Aula3.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parte 1
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //Funcionario yona = new Funcionario(2000, "123456789-12");

            Diretor yona = new Diretor("926.790.030-71");
            yona.Nome = "Yona";
            //yona.Salario = 2000;

            Console.WriteLine(yona.Nome);
            Console.WriteLine("Bonificação: " + yona.GetObterBonificacao());

            Diretor hak = new Diretor("123456789-12");

            hak.Nome = "Hak";
            //hak.CPF = "123456789-12";
            //hak.Salario = 2000;

            Console.WriteLine(yona.Nome);
            Console.WriteLine("Bonificação: " + hak.GetObterBonificacao());

            gerenciador.Registrar(yona);
            gerenciador.Registrar(hak);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.WriteLine(hak.GetObterBonificacao());
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            yona.AumentarSalario();
            Console.WriteLine(yona.Salario);

            CalcularBonificacao();
            UsarSistma();
        }
            

            //parte 3
            public static void UsarSistma()
            {
                SistemaInterno sistema = new SistemaInterno();

                Diretor Roberta =  new Diretor("178.116.960-88");
                Roberta.Nome = "Roberta";
                Roberta.Senha = "123";

                Console.WriteLine("\nResultado do DIretor");

                sistema.Logar(Roberta, "123");
                sistema.Logar(Roberta, "333");

                GerenteDeConta Camila = new GerenteDeConta("178.116.960-88");
                Camila.Nome = "Camila";
                Camila.Senha = "123" ;

                Console.WriteLine("\nResultado do gerente de conta");

                sistema.Logar(Camila, "123");
                sistema.Logar(Camila, "333");

                ParceiroComercial parceiro = new ParceiroComercial();
                parceiro.Senha = "12345";

                Console.WriteLine("\nResultado do parceiro comercial");

                sistema.Logar(parceiro, "12345");
                sistema.Logar(parceiro, "123");
            }

            //parte 2
            public static void CalcularBonificacao()
            {
                GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

                Designer Anahi = new Designer("490.695.695.23");
                Anahi.Nome = "Anahi";

                Diretor Roberta =  new Diretor("178.116.960-88");
                Roberta.Nome = "Roberta";

                Auxiliar Lupita = new Auxiliar("540.174.450-12");
                Lupita.Nome ="Lupita";

                GerenteDeConta Camila = new GerenteDeConta("178.116.960-88");
                Camila.Nome = "Camila";

                gerenciadorBonificacao.Registrar(Anahi);
                gerenciadorBonificacao.Registrar(Roberta);
                gerenciadorBonificacao.Registrar(Lupita);
                gerenciadorBonificacao.Registrar(Camila);

                Console.WriteLine("Total de bonificação do mês " + gerenciadorBonificacao.GetTotalBonificacao());
            }
        
    }
}
