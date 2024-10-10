using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios1234
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Verifica;
            do
            {
                menuListas();
                Console.WriteLine("Deseja continuar executando as listas de exercícios (S/N): \n");
                Verifica = Console.ReadLine().ToUpper();

            } while (Verifica == "S");

        }

        private static void menuListas()
        {
            Console.Clear();
            int op = 0;
            Console.WriteLine("*** Menu Principal ***");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1 - Primeira lista de atividades ");
            Console.WriteLine("2 - Segunda lista de atividades");
            Console.WriteLine("3 - Terceira lista de atividades");
            Console.WriteLine("0 - Para finalizar");

            Console.WriteLine("Numero da lista: ");
            op = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------------");

            switch (op)
            {
                case 0:
      
                    Environment.Exit(0);
                    break;

                case 1:   //Menu da primeira Lista de atividades
                    Lista1 lista1 = new Lista1();
                    Console.Clear();
                    int opLista1 = 0;
                    Console.WriteLine("*** Menu Principal - Lista 1***");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("1 - Primeira atividade ");
                    Console.WriteLine("2 - Segunda atividade");
                    Console.WriteLine("3 - Terceira  atividade");
                    Console.WriteLine("4 - Terceira  atividade");
                    Console.WriteLine("5 - Terceira  atividade");
                    Console.WriteLine("6 - Terceira  atividade");
                    Console.WriteLine("7 - Terceira  atividade");
                    Console.WriteLine("8 - Terceira  atividade");
                    Console.WriteLine("9 - Terceira  atividade");
                    Console.WriteLine("10 - Terceira  atividade");
                    Console.WriteLine("Digite o numero da atividade: ");
                    opLista1 = int.Parse(Console.ReadLine());

                    switch (opLista1)
                    {

                        case 1:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.exercicio1();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.exercicio2();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.exercicio3();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.exercicio4();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.exercicio5();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.exercicio6();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.exercicio7();
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.exercicio8();
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.exercicio9();
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.exercicio10();
                            break;
                        default:
                            Console.WriteLine("Tente outro item da lista");
                            break;

                    }
                    break;
                case 2:
                 
                    Lista2 lista2 = new Lista2();
                    Console.Clear();
                    int opLista2 = 0;
                    Console.WriteLine("*** Menu Principal - Lista 2 ***");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("1 - Primeira atividade ");
                    Console.WriteLine("2 - Primeira atividade ");
                    Console.WriteLine("3 - Primeira atividade ");
                    Console.WriteLine("4 - Primeira atividade ");
                    Console.WriteLine("5 - Primeira atividade ");
                    Console.WriteLine("6 - Primeira atividade ");
                    Console.WriteLine("7 - Primeira atividade ");
                    Console.WriteLine("8 - Primeira atividade ");
                    Console.WriteLine("9 - Primeira atividade ");
                    Console.WriteLine("10 - Segunda atividade");
                    Console.WriteLine("11 - Terceira  atividade");
                    Console.WriteLine("Digite o numero da atividade: ");
                    opLista2 = int.Parse(Console.ReadLine());

                    switch (opLista2)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.exercicio1();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.exercicio2();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.exercicio3();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.exercicio4();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.exercicio5();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.exercicio6();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.exercicio7();
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.exercicio8();
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.exercicio9();
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.exercicio10();
                            break;
                        case 11:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.exercicio11();
                            break;
                        default:
                            Console.WriteLine("Tente outro item da lista");
                            break;
                    }
                    break;


            }

        }

       
    }
}
