using System;

namespace Exercicio2_Estruturas_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do usuário: ");//exibição da mensagem 
            string usuario = (Console.ReadLine());//entrada e armazenamento do nome do usuário
            Console.Write("Digite a senha do usuário (senha numérica de 6 dígitos): ");//exibição da mensagem
            string senha = (Console.ReadLine());//entrada e armazenamento da senha 

            while(usuario == senha){//enquanto usuário for igual a senha,então :
                Console.WriteLine("Senha não pode ser igual usuário !");//exibição da mensagem
                Console.Write("Digite o nome do usuário: ");//exibição da mensagem
                usuario = (Console.ReadLine());//entrada e armazenamento do nome do usuário
                Console.Write("Digite a senha do usuário (senha numérica de 6 dígitos): ");//exibição da msg
                senha = (Console.ReadLine());//entrada e armazenamento da senha 
            }

            Console.WriteLine("Usuário e Senha recebidos com sucesso !");//exibição da mensagem
        }
    }
}



//Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações


