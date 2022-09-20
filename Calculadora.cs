using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{

    class Program
    {
        enum Menu {Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7}
        static void Main(string[] args)
        {

            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções:");
                Console.WriteLine("1) Soma\n2) Subtracao\n3) Divisao\n4) Multiplicacao\n5) Potencia\n6) Raiz\n7) Sair\n");


                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;

                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Divisao:
                        Divisao();
                        break;

                    case Menu.Multiplicacao:
                        Multiplicao();
                        break;

                    case Menu.Potencia:
                        Potenceia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.WriteLine(opcao);

                Console.ReadLine();
                Console.Clear();
            }

        }

        static void Soma()
        {
            Console.WriteLine("SOMA DE DOIS NUMEROS!!\n ");
            Console.Write("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}\n");
            Console.WriteLine("Aperte ENTER para volar ao menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("SUBTRAÇÃO DE DOIS NUMEROS!!\n ");
            Console.Write("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}\n");
            Console.WriteLine("Aperte ENTER para volar ao menu");
            Console.ReadLine();
        }
        static void Divisao()
        {
            Console.WriteLine("DIVISÃO DE DOIS NUMEROS!!\n ");
            Console.Write("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b; // importante converter para float por ser divisão!
            Console.WriteLine($"O resultado é: {resultado}\n");
            Console.WriteLine("Aperte ENTER para volar ao menu");
            Console.ReadLine();
        }
        static void Multiplicao()
        {
            Console.WriteLine("MULTIPLICAÇÃO DE DOIS NUMEROS!!\n ");
            Console.Write("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}\n");
            Console.WriteLine("Aperte ENTER para volar ao menu");
            Console.ReadLine();
        }
        static void Potenceia()
        {
            Console.WriteLine("POTENCIALIZAÇÃO DE DOIS NUMEROS!!\n ");
            Console.Write("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é: {resultado}\n");
            Console.WriteLine("Aperte ENTER para volar ao menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("RAIZ QUADRADA!!\n ");
            Console.Write("Digite um numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado}\n");
            Console.WriteLine("Aperte ENTER para volar ao menu");
            Console.ReadLine();
        }
    }
}