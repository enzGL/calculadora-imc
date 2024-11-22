using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculaimctry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            double peso = 0;
            double altura = 0;
            bool flag = false;


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("======================\n");
            Console.Write("= Calculadora de imc =");
            Console.Write("\n======================\n");
            Console.ResetColor();

            try
            {
                while (!flag)
                {
                    Console.Write("\nDigite sua idade(ou 'S' para sair): ");
                    String input1 = Console.ReadLine();

                    if (input1.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa encerrado.");
                        return;
                    }

                    try
                    {

                        idade = int.Parse(input1);
                        flag = true;
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
                    }
                }

                flag = false;

                while (!flag)
                {

                    Console.Write("\nDigite a sua altura em metros(ou 'S' para sair): ");
                    String input2 = Console.ReadLine();

                    if (input2.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa encerrado.");
                        return;
                    }
                    try
                    {
                        altura = double.Parse(input2);

                        if (altura < 1 || altura > 2.5)
                        {
                            Console.WriteLine("Erro: Por favor digite uma altura valida.");
                            continue;
                        }

                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
                    }
                }

                flag = false;

                while (!flag)
                {

                    Console.Write("\nDigite o seu peso em kg(ou 'S' para sair): ");
                    String input3 = Console.ReadLine();

                    if (input3.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa encerrado.");
                        return;
                    }
                    try
                    {
                        peso = double.Parse(input3);

                        if (altura < 1 || altura > 2.5)
                        {
                            Console.WriteLine("Erro: Por favor digite um peso valido.");
                            continue;
                        }

                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
                    }
                }
              
                double imc = peso / (altura * altura);

                Console.WriteLine($"\nSeu IMC é: {imc:F2}");

                if (imc < 18.5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Classificação: Abaixo do peso.");
                    Console.ResetColor();
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Classificação: Peso normal.");
                    Console.ResetColor();
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Classificação: Sobrepeso.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Classificação: Obesidade.");
                    Console.ResetColor();
                }
            }
            finally
            {

                Console.WriteLine("\nOperação concluída.");
                Console.ReadKey();
            }
        }
    }
}
