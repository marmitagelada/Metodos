using System;
using Ex1.Classes;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Informe o valor 1: ");
            double valor1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o valor 2: ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.Clear();

            System.Console.WriteLine("Menu de Opções:");
            System.Console.WriteLine("1 = Somar");
            System.Console.WriteLine("2 = Subtrair");
            System.Console.WriteLine("3 = Multiplicar");
            System.Console.WriteLine("4 = Dividir");

            int opcao = int.Parse(Console.ReadLine());
            
            switch (opcao){
                case 1:{
                    double resultado = calc.Somar(valor1, valor2);
                    System.Console.WriteLine($"{valor1} + {valor2} = {resultado}");
                    break;
                }

                case 2:{
                    double resultado = calc.Subtrair(valor1, valor2);
                    System.Console.WriteLine($"{valor1} - {valor2} = {resultado}");
                    break;
                }

                case 3:{
                    double resultado = calc.Mult(valor1, valor2);
                    System.Console.WriteLine($"{valor1} * {valor2} = {resultado}");
                    break;
                }

                case 4:{
                    double resultado = calc.Mult(valor1, valor2);
                    System.Console.WriteLine($"{valor1} / {valor2} = {resultado}");
                    break;
                }

                default:{
                    System.Console.WriteLine("Opção Inválida");
                    break;
                }
            }
        }
    }
}
