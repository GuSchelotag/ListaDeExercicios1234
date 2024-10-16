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
            Console.WriteLine("4 - Quarta lista de atividades");
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
                    Console.WriteLine("3 - Terceira atividade");
                    Console.WriteLine("4 - Quarta atividade");
                    Console.WriteLine("5 - Quinta atividade");
                    Console.WriteLine("6 - Sexta atividade");
                    Console.WriteLine("7 - Setima atividade");
                    Console.WriteLine("8 - Oitava atividade");
                    Console.WriteLine("9 - Nona atividade");
                    Console.WriteLine("10 - Decima atividade");
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
                    Console.WriteLine("2 - Segunda atividade");
                    Console.WriteLine("3 - Terceira atividade");
                    Console.WriteLine("4 - Quarta atividade");
                    Console.WriteLine("5 - Quinta atividade");
                    Console.WriteLine("6 - Sexta atividade");
                    Console.WriteLine("7 - Setima atividade");
                    Console.WriteLine("8 - Oitava atividade");
                    Console.WriteLine("9 - Nona atividade");
                    Console.WriteLine("10 - Decima atividade");
                    Console.WriteLine("11 - Decima Primeira atividade");
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
                case 3:

                    Lista3 lista3 = new Lista3();
                    Console.Clear();
                    int opLista3 = 0;
                    Console.WriteLine("*** Menu Principal - Lista 2 ***");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("1 - Primeira atividade ");
                    Console.WriteLine("2 - Segunda atividade");
                    Console.WriteLine("3 - Terceira atividade");
                    Console.WriteLine("4 - Quarta atividade");
                    Console.WriteLine("5 - Quinta atividade");
                    Console.WriteLine("6 - Sexta atividade");
                    opLista3 = int.Parse(Console.ReadLine());

                    switch (opLista3)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.exercicio1();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.exercicio2();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.exercicio3();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.exercicio4();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.exercicio5();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.exercicio6();
                            break;
                        default:
                            Console.WriteLine("Tente outro item da lista");
                            break;

                    }
                    break;
             
                    

                case 4:   //Menu da primeira Lista de atividades
                  
                    Lista4 lista4 = new Lista4();
                    Console.Clear();
                    int opLista4 = 0;
                    Console.WriteLine("*** Menu Principal - Lista 1***");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("1 - Primeira atividade ");
                    Console.WriteLine("2 - Segunda atividade");
                    Console.WriteLine("3 - Terceira atividade");
                    Console.WriteLine("4 - Quarta atividade");
                    Console.WriteLine("5 - Quinta atividade");
                    Console.WriteLine("6 - Sexta atividade");
                    Console.WriteLine("7 - Setima atividade");
                    Console.WriteLine("8 - Oitava atividade");
                    Console.WriteLine("9 - Nona atividade");
                    Console.WriteLine("10 - Decima atividade");
                    Console.WriteLine("Digite o numero da atividade: ");
                    opLista4 = int.Parse(Console.ReadLine());

                    switch (opLista4)
                    {

                        case 1:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.exercicio1();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.exercicio2();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.exercicio3();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.exercicio4();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.exercicio5();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.exercicio6();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.exercicio7();
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.exercicio8();
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.exercicio9();
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.exercicio10();
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
