using System;

namespace ListaExercicios1234
{
    internal class Lista4
    {
        public Lista4()
        {
        }

        internal void exercicio1()
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

        internal void exercicio10()
        {
            Console.WriteLine("Digite um ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine($"{ano} é um ano bissexto.");
            }
            else
            {
                Console.WriteLine($"{ano} não é um ano bissexto.");
            }

            Console.ReadKey();
        }

        internal void exercicio2()
        {
            Console.WriteLine("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 12)
            {
                Console.WriteLine("Criança");
            }
            if (idade > 13 && idade < 17)
            {
                Console.WriteLine("Adolescente");
            }
            if (idade > 17 && idade < 64)
            {
                Console.WriteLine("Adulto");
            }
            if (idade > 64 && idade > 65)
            {
                Console.WriteLine("Idoso");
            }

            Console.ReadKey();
        }

        internal void exercicio3()
        {
            Console.WriteLine("Digite a nota do aluno: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota < 4)
            {
                Console.WriteLine("Reprovado");
            }
            if (nota > 4 && nota < 5.9)
            {
                Console.WriteLine("Recuperação");
            }
            if (nota > 5.9 && nota < 10)
            {
                Console.WriteLine("Aprovado");
            }

            Console.ReadKey();
        }

        internal void exercicio4()
        {
            Console.Write("Digite seu peso (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine("Seu IMC é: "+ imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Abaixo do peso");
            }
            if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Classificação: Peso normal");
            }
            if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade");
            }
        }

        internal void exercicio5()
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O maior número é: " + numero1);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"O maior número é: " + numero2);
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }

        internal void exercicio6()
        {
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18 && idade <= 70)
            {
                Console.WriteLine("Você é obrigado a votar.");
            }
            else if ((idade >= 16 && idade < 18) && idade > 70)
            {
                Console.WriteLine("Seu voto é facultativo.");
            }
            else if (idade < 16)
            {
                Console.WriteLine("Você não pode votar.");
            }
        }

        internal void exercicio7()
        {
            Console.Write("Digite o valor da compra: R$ ");
            double valorCompra = double.Parse(Console.ReadLine());

            double valorFinal;

            if (valorCompra > 100)
            {
                valorFinal = valorCompra - (valorCompra * 0.10);
                Console.WriteLine("Valor com desconto de 10%: R$ " + valorFinal);
            }
            else
            {
                valorFinal = valorCompra;
                Console.WriteLine($"Valor da compra: R$ " + valorFinal);
            }
        }

        internal void exercicio8()
        {
            Console.WriteLine("Digite a Temperatura atual: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp < 15)
            {
                Console.WriteLine(temp +"ºC"+ " Frio");
            }
            if (temp > 15 && temp < 25)
            {
                Console.WriteLine(temp + "ºC" + " Agradavel");
            }
            if (temp > 25 && temp < 99)
            {
                Console.WriteLine(temp + "ºC" + " Quente");
            }

            Console.ReadKey();
        }

        internal void exercicio9()
        {
            decimal nota1, nota2, nota3, media;
            Console.WriteLine("Digite a Primera nota: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a Segunda nota: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a Terceira nota: ");
            nota3 = Convert.ToDecimal(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("O aluno está APROVADO." + media);
            }
            else
            {
                Console.WriteLine("O aluno está REPROVADO." + media);
            }

            Console.ReadKey();
        }
    }
}