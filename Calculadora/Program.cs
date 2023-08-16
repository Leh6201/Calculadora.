using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Calculadora - Escolha uma opção:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Resto da Divisão");
                Console.WriteLine("6 - Potenciação");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        RealizarOperacao("+");
                        break;
                    case 2:
                        RealizarOperacao("-");
                        break;
                    case 3:
                        RealizarOperacao("*");
                        break;
                    case 4:
                        RealizarOperacao("/");
                        break;
                    case 5:
                        RealizarOperacao("%");
                        break;
                    case 6:
                        RealizarPotenciacao();
                        break;
                    case 0:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void RealizarOperacao(string operador)
        {
            Console.Write("Digite o primeiro valor: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 != 0)
                        resultado = numero1 / numero2;
                    else
                        Console.WriteLine("Não é possível dividir por zero.");
                    break;
                case "%":
                    resultado = numero1 % numero2;
                    break;
            }

            Console.WriteLine($"Resultado: {resultado}\n");
        }

        static void RealizarPotenciacao()
        {
            Console.Write("Digite a base: ");
            double baseNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            double expoente = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Pow(baseNumero, expoente);

            Console.WriteLine($"Resultado: {resultado}\n");
        }
    }
}