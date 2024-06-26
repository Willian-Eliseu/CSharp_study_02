using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            bool executando = true;
            while (executando)
            {
                Console.WriteLine("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Selecione a operação: ");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");

                int operacao = Convert.ToInt32(Console.ReadLine());
                double resultado = 0;

                switch (operacao)
                {
                    case 1:
                        resultado = soma(numero1, numero2);
                        break;
                    case 2:
                        resultado = subtracao(numero1, numero2);
                        break;
                    case 3:
                        resultado = multiplicacao(numero1, numero2);
                        break;
                    case 4:
                        resultado = divisao(numero1, numero2);
                        break;
                    case 5:
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Operação inválida.");
                        break;
                }

                if(resultado == 0 && !executando){
                    Console.WriteLine("Você saiu!");
                }else{
                    Console.WriteLine("O resultado é: " + resultado);
                }
                
                Console.ReadLine();
            }
        }

        static double soma(double n1, double n2)
        {
            return n1 + n2;
        }

        static double subtracao(double n1, double n2)
        {
            return n1 - n2;
        }

        static double multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        static double divisao(double n1, double n2)
        {
            double quociente = n1 / n2;
            return quociente;
        }


    }
}