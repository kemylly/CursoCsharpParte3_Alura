using ByteBank;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace KYCS.My_Private_Documents.Formacao_CSharp.formacaocsharp.Aula3.Sistemas
{
    public class SistemaInterno
    {
        // public bool Logar(Diretor funcionario, string senha)
        // {
        //     bool usuarioAutenticado = funcionario.Autenticar(senha);

        //     if(usuarioAutenticado)
        //     {
        //         Console.WriteLine("Bem vindo ao sistema");
        //         return true;
        //     }
        //     else{
        //         Console.WriteLine("Senha incorreta");
        //         return false;
        //     }
        // }

        // public bool Logar(GerenteDeConta funcionario, string senha)
        // {
        //     bool usuarioAutenticado = funcionario.Autenticar(senha);

        //     if(usuarioAutenticado)
        //     {
        //         Console.WriteLine("Bem vindo ao sistema");
        //         return true;
        //     }
        //     else{
        //         Console.WriteLine("Senha incorreta");
        //         return false;
        //     }
        // }

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            else{
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }

        // public bool Logar(ParceiroComercial funcionario, string senha)
        // {
        //     bool usuarioAutenticado = funcionario.Autenticar(senha);

        //     if(usuarioAutenticado)
        //     {
        //         Console.WriteLine("Bem vindo ao sistema");
        //         return true;
        //     }
        //     else{
        //         Console.WriteLine("Senha incorreta");
        //         return false;
        //     }
        // }
    }
}