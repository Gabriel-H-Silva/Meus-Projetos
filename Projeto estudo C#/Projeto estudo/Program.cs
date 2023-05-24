using Projeto_estudo;
using System;
using Projeto_estudo.exercises;

namespace Sistema
{
    class Program
    {
        static void Main()
        {
            string secret = "";
            // intrução
            Console.WriteLine("Olá Bem vindo Projeto de Estudo e pratica de C#");
            Console.WriteLine("Certo... Vamos começar...");
            Console.WriteLine(" 'pressione {Enter} para iniciar' ");
            secret = Console.ReadLine();

            if (secret == "carneiros") { string User = "Gabriel"; menu(User); }
            else { login(); }
        }

        static void login()
        {
            // Sistema de Login
            string User = "";
            string Password = "";
            Console.WriteLine("Bem vindo a tela de Login");

            // Usuario
            Console.WriteLine("Usuario: ");
            User = Console.ReadLine();

            // Senha
            Console.WriteLine("Senha: ");
            Password = Console.ReadLine();

            // Verificação dos dados
            bool Usercorrect = false;
            bool Passwordcorrect = false;
            if (User == "Gabriel")
            {
                Usercorrect = true;
            }
            if (Password == "123456")
            {
                Passwordcorrect = true;
            }

            //verificação final
            if (Usercorrect == true && Passwordcorrect == true)
            {
                // Login Aprovado
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login aprovado");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                menu(User);
            }
            else
            {
                // Login Negado
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usuario ou Senha incorreto");                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" 'pressione {Enter} para reiniciar' ");
                Console.ReadLine();
                login();

            }

        }

        static void menu(string User)
        {
            Console.Clear();
            Console.Write("Olá ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(User);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("O que vamos fazer hoje?");


            int selecao;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 1 | Calculadora");
            Console.WriteLine(" 2 | Lista de exercicios 1");
            Console.WriteLine(" 3 | Estoque de produtos");
            Console.ForegroundColor = ConsoleColor.White;

            selecao = int.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    calculadora(User);
                    break;
                case 2:
                    exercises_list1.exercises1();
                    break;
                case 3:
                    Store_product.store_product(User);
                    break;
            }

            
        }
        static void calculadora(string User)
        {
            Console.Clear();
            Console.WriteLine("Calculadora");
            Console.WriteLine();

            int valor;
            string Operador = "";
            int selecao;
            int val = 0;
            int val2 = 0;

            bool endOperacao = true;
            List<int> ArrayNumeros = new List<int>();
            List<string> ArrayOperador = new List<string>();
            Console.WriteLine("Os operadores são");
            Console.WriteLine("+ adição | - subtração | = Resultado");
            while (endOperacao == true)
            {

                val += 1;

                Console.WriteLine("Valor " + val + ":");
                valor = int.Parse(Console.ReadLine());
                ArrayNumeros.Add(valor);

                Operador = Console.ReadLine();
                if (Operador == "+")
                {
                    ArrayOperador.Add(Operador);
                    continue;
                }
                else if (Operador == "-")
                {
                    ArrayOperador.Add(Operador);
                    continue;
                }
                else if (Operador == "=")
                {
                    endOperacao = false;
                    Operador = "end";
                    ArrayOperador.Add(Operador);
                    ArrayNumeros.Add(0);

                    int[] Numeros = ArrayNumeros.ToArray();
                    string[] Operadores = ArrayOperador.ToArray();

                    int Resultado = 0;

                    int i;
                    for (i = 0; i < Numeros.Length; i++)
                    {
                        int Numero = Numeros[i];
                        int Numero2 = Numeros[i + 1];
                        string Operador2 = Operadores[i];


                        if (Operador2 == "+") { 

                            Resultado = Numero + Numero2;
                        }

                        else if (Operador2 == "-")
                        {
                            Resultado = Numero - Numero2;
                        }

                        else if (Operador2 == "end")
                        {
                            Console.WriteLine("Resultado: " + Resultado);
                            break;
                        }

                        
                    }
                    
                    
                };
            }
            Console.WriteLine();
            Console.WriteLine("Voltar pro menu?");
            Console.WriteLine();
            Console.WriteLine("1 | Sim");
            Console.WriteLine("2 | Não");


            selecao = int.Parse(Console.ReadLine());

            if(selecao == 1) {
                menu(User);
            }
            else
            {
                calculadora(User);
            }
        }

        

    }
}