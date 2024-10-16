using System;
using System.Runtime.Serialization;
using System.Xml;

namespace ListaExercicios1234
{
    internal class Lista3
    {
        public Lista3()
        {
        }

        internal void exercicio1()
        {
            decimal soma;
            Console.WriteLine("Digite o primeiro valor: ");
            decimal numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            decimal numero2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            decimal numero3 = Convert.ToDecimal(Console.ReadLine());

            soma = numero1 + numero2 + numero3;

            Console.WriteLine("A soma dos tres valores é de: " + soma);

            Console.ReadKey();

        }

        internal void exercicio2()
        {
            decimal nota1, nota2, nota3, nota4, media;
            Console.WriteLine("Digite a Primera nota: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a Segunda nota: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a Terceira nota: ");
            nota3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a Quarta nota: ");
            nota4 = Convert.ToDecimal(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("A média do aluno é " + media);

            Console.ReadKey();
        }

        internal void exercicio3()
        {

            string nome;

            Console.Write("Digite um nome: ");
            nome = Console.ReadLine();


            if (nome != "Gustavo")
            {
                Console.WriteLine("Nome incorreto !!"); exercicio3();
            }
            else
            {
                Console.WriteLine("Nome recebido: " + nome);
            }

        }

        internal void exercicio4()
        {
            int contagemPares = 0;

            for (int numero = 35; numero <= 98111; numero++)
            {
                if (numero % 2 == 0)
                {
                    contagemPares++;
                }
            }

            Console.WriteLine("Quantidade de números pares entre 35 e 98.111: " + contagemPares);
        }

        internal void exercicio5()
        {
            int somaImpares = 0;

            for (int i = 1; i <= 5000; i++)
            {
                if (i % 2 != 0)
                {
                    somaImpares += i;
                }
            }

            Console.WriteLine("Soma de todos os números ímpares de 1 a 5000: " + somaImpares);

        }

        internal void exercicio6()
        {
            Console.Write("Digite um número para ver sua tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do " + numero + " : ");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}
    
