using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1234
{
    internal class Lista1
    {


        public  void exercicio10()
        {
            Console.Write("Digite a largura da parede: ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da parede: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = largura * altura;
          
            double tinta = area / 2;

           
            Console.WriteLine("A área a ser pintada é de " + area);
            Console.WriteLine("A quantidade de tinta necessária é de " + tinta + " litros ");

            Console.ReadKey();
        }

        public  void exercicio9()
        {
            Console.WriteLine("Quantia em R$ ");
            double reais = Convert.ToDouble(Console.ReadLine());

            double valordolar = 5.60;

            double dolar = reais / valordolar;

            Console.WriteLine("Com R$" + reais + " você pode comprar US$" + dolar);

            Console.ReadKey();


        }

        public  void exercicio8()
        {
            Console.Write("Digite uma distância em metros: ");
            decimal metros = Convert.ToDecimal(Console.ReadLine());

   
            decimal quilometros = metros / 1000;
            decimal hectometros = metros / 100;
            decimal decametros = metros / 10;
            decimal decimetros = metros * 10;
            decimal centimetros = metros * 100;
            decimal milimetros = metros * 1000;


            Console.WriteLine("A distância de "+ metros + "m corresponde a:");
            Console.WriteLine(quilometros + " Km");
            Console.WriteLine(hectometros + " Hm");
            Console.WriteLine(decametros + " Dam");
            Console.WriteLine(decimetros + " dm");
            Console.WriteLine(centimetros + " cm");
            Console.WriteLine(milimetros + " mm");

            Console.ReadKey();
        }

        public  void exercicio7()
        {

            Console.Write("Digite um número: ");
            decimal numero = Convert.ToDecimal(Console.ReadLine());

            decimal dobro = numero * 2;
            decimal tercaparte = numero / 3;

            Console.Write("O dobro de " + numero + " é " + dobro + "\n");
            Console.WriteLine("A terça parte de " + numero + " é " + tercaparte);



            Console.ReadKey();
        }

        public  void exercicio6()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int antecessor = numero - 1;
            int sucessor = numero + 1;

            Console.WriteLine("O antecessor de " + numero + " é: " + antecessor);
            Console.WriteLine("O sucessor de " + numero + " é: " + sucessor);

            Console.ReadKey();
        }

        public  void exercicio5()
        {
            decimal nota1, nota2, media;
            Console.WriteLine("Digite a Primera nota: ");
            nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a Segunda nota: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine("A média do aluno é " + media);

            Console.ReadKey();
        }

        public  void exercicio4()
        {
            decimal num1, num2, soma;
            Console.WriteLine("Digite o Primero número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o Segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine("A soma de " + num1 + " + " + num2 + " é: " + soma);
            
                Console.ReadKey();


        }

        public  void exercicio3()
        {
            string nome;
            decimal salario;
            Console.WriteLine("Nome do Funcionário ");
            nome = Console.ReadLine();

            Console.WriteLine("Salário: ");
            salario = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("O funcionário " + nome + " tem um salario de " + salario + " em outubro 2024");
            Console.ReadKey();
        }

        public  void exercicio2()
        {
            string nome;
            Console.WriteLine("Qual é seu nome ? ");
            nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome + ", é um prazer te conhecer !");
            Console.ReadKey();
        }

        public  void exercicio1()
        {
            Console.WriteLine("Olá, Mundo !!");
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
