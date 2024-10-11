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
            int A, B, C;

            Console.WriteLine("Digite o primeiro valor:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            C = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (A < B && A < C)
            {
                if (B < C)
                {
                    Console.WriteLine(A + "\n" + B + "\n" + C);
                }
                else
                {
                    Console.WriteLine(A + "\n" + C + "\n" + B);
                }
            }
            else if (B < A && B < C)
            {
                if (A < C)
                {
                    Console.WriteLine(B + "\n" + A + "\n" + C);
                }
                else
                {
                    Console.WriteLine(B + "\n" + C + "\n" + A);
                }
            }
            else
            {
                if (A < B)
                {
                    Console.WriteLine(C + "\n" + A + "\n" + B);
                }
                else
                {
                    Console.WriteLine(C + "\n" + B + "\n" + A);

                }
            }
        }

        internal void exercicio11()
        {
            int inicio, fim;

            Console.WriteLine("Digite a hora de início do jogo (0 a 23):");
            inicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a hora de fim do jogo (0 a 23):");
            fim = Convert.ToInt32(Console.ReadLine());

            if (inicio < 0 || inicio > 23 || fim < 0 || fim > 23)
            {
                Console.WriteLine("As horas devem estar entre 0 e 23.");
                return;
            }
            int duracao;
            if (fim >= inicio)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = (24 - inicio) + fim;
            }
            if (duracao > 24)
            {
                Console.WriteLine("A duração do jogo excedeu o tempo permitido de 24 horas.");
                return;
            }
            int horasRestantes = 24 - duracao;

            Console.WriteLine($"Horas jogadas: {duracao} horas");
            Console.WriteLine($"Horas restantes: {horasRestantes} horas");
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
            int A, B, C;

            Console.WriteLine("Digite o primeiro valor:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            C = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (A > B && A > C)
            {
                if (B > C)
                {
                    Console.WriteLine(A + "\n" + B + "\n" + C);
                }
                else
                {
                    Console.WriteLine(A + "\n" + C + "\n" + B);
                }
            }
            else if (B > A && B > C)
            {
                if (A > C)
                {
                    Console.WriteLine(B + "\n" + A + "\n" + C);
                }
                else
                {
                    Console.WriteLine(B + "\n" + C + "\n" + A);
                }
            }
            else
            {
               if (A > B)
                {
                    Console.WriteLine(C + "\n" + A + "\n" + B);
                }
                else
                {
                    Console.WriteLine(C + "\n" + B+ "\n" + A);

                }
             
            }


        }
    }
}
