using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ListaExercicios1234
{
    internal class Lista2
    {
        internal void exercicio1()
        {
            Console.Write("Digite um número: ");
            decimal numero = Convert.ToDecimal(Console.ReadLine());

            if (numero > 20)
            {
                Console.WriteLine("O número digitado é: " + numero);
            }
            else
            {
                Console.WriteLine("O número digitado não é maior que 20.");

            }
        }

        internal void exercicio10()
        {
            throw new NotImplementedException();
        }

        internal void exercicio11()
        {
            throw new NotImplementedException();
        }

        internal void exercicio2()
        {
            Console.WriteLine("Escreva um número: ");
            decimal numero = Convert.ToDecimal(Console.ReadLine());

            if (numero > 10)
            {
                Console.WriteLine("O número " + numero + " é maior que 10");
            }
            else
            {
                Console.WriteLine("O número " + numero + " é menor que 10");
            }
            Console.ReadKey();
        }

        internal void exercicio3()
        {
            Console.Write("Digite o valor de A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A + B < C)
            {
                Console.WriteLine("A soma de A e B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A e B não é menor que C.");
            }
        }

        internal void exercicio4()
        {
            Console.WriteLine("Digite seu número: ");
            decimal numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite seu número: ");
            decimal numero2 = Convert.ToDecimal(Console.ReadLine());
            
            
            decimal soma = numero1 + numero2;

            if (soma > 10)
            {
                Console.WriteLine("A soma é de " + soma);
            }
            else
            {
                Console.WriteLine("A soma não é maior que 10");

            }
            Console.ReadKey();
         

        }

        internal void exercicio5()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu sexo (M/F): ");
            string sexo = Console.ReadLine().ToUpper();

            Console.Write("Digite seu estado civil: ");
            string estadoCivil = Console.ReadLine().ToUpper();

            if (sexo == "F" && estadoCivil == "CASADA")
            {
               
                Console.Write("Digite o tempo de casada (em anos): ");
                int anosCasada = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Estado Civil: {estadoCivil}, Tempo de Casada: {anosCasada} anos.");
            }
            else
            {
              
                Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Estado Civil: {estadoCivil}.");
            }
            Console.ReadKey(); 
        }

        internal void exercicio6()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());


            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }

        internal void exercicio7()
        {
            int A, B, C;

            Console.Write("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                C = A + B;
            }
            else
            {
                C = A * B;
            }

            Console.WriteLine("O resultado é: " + C);
            Console.ReadKey();
        }

        internal void exercicio8()
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                int resultado = numero * 2;
                Console.WriteLine("O dobro do número é: " + resultado);
            }
            else if (numero < 0)
            {
                int resultado = numero * 3;
                Console.WriteLine("O triplo do número é: " + resultado);
            }
            else
            {
                Console.WriteLine("O número é zero e não se aplica a cálculos.");
            }

        }

        internal void exercicio9()
        {
            throw new NotImplementedException();
        }
    }
}
