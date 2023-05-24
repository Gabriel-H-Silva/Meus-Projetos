using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace projeto_de_estudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textotest = "Hello World!";
            string Nome = "";          

            // primeira parte execução

            Console.WriteLine(textotest);
            Console.WriteLine("Bem vindo ao meu sistema de estudo");

            Console.WriteLine("Escreve seu nome: ");

            Nome = Console.ReadLine();

            Console.WriteLine("Olá " + Nome + " seja bem vindo!!! ");

            Console.WriteLine("Bom vamos lá. O que voce deseja realizar?");

            Inicio();
            
        }
        static void Inicio()
        {
            // inicio e aula de comando basico

            string action = "";

            Console.WriteLine("Recusos Disponível: (para utilizar basta digitar o nome do recurso)");

            Console.WriteLine("soma");

            Console.WriteLine("subtracao");

            Console.WriteLine("Calculadora");

            action = Console.ReadLine();

            if (action == "soma")
            {
                Console.Clear();
                ExecSoma();
            }
            else if (action == "subtracao")
            {
                Console.Clear();
                ExecSub();
            }
            else if (action == "Calculadora")
            {
                bool isfirst = true;
                Console.Clear();
                ExecCalculadora(isfirst);
            }

            Console.ReadLine();
        }

        static void ExecSoma()
        {
            // comandos basicos
            float Resultado = 0;
            int sm1 = 0;
            int sm2 = 0;
            string action = "";

            Console.WriteLine("Certo vamos lá, vamos realizar um soma!");

            Console.WriteLine("Forneça os valores:");

            sm1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sm1 + " + " );

            sm2 = Convert.ToInt32(Console.ReadLine());

            Resultado = sm1 + sm2;

            Console.WriteLine(sm1 + " + " + sm2 + " = " + Resultado);

            Console.WriteLine("Quer continuar fazendo soma?(s|n)");

            action = Console.ReadLine();

            if(action == "s")
            {
                Console.Clear();
                ExecSoma();
                
            }
            else
            {
                Console.Clear();
                Inicio();
            }

            

        }

        static void ExecSub()
        {
            // comandos basicos 
            float Resultado = 0;
            int sm1 = 0;
            int sm2 = 0;
            string action = "";

            Console.WriteLine("Certo vamos lá, vamos realizar um subtracao!");

            Console.WriteLine("Forneça os valores:");

            sm1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sm1 + " - ");

            sm2 = Convert.ToInt32(Console.ReadLine());

            // processamento 

            Resultado = sm1 - sm2;

            Console.WriteLine(sm1 + " - " + sm2 + " = " + Resultado);

            Console.WriteLine("Quer continuar fazendo subtracao?(s|n)");

            action = Console.ReadLine();

            if (action == "s")
            {
                Console.Clear();
                ExecSub();

            }
            else
            {
                Console.Clear();
                Inicio();
            }



        }

        static void ExecCalculadora(bool isfirst)
        {
            // C# switch case exemplo

            if (isfirst = true)
            {
                Console.WriteLine("Bem Vindo a Calculadora!!");
                Console.WriteLine("A Calculadora é uma função pra substituir as 4 funçoes de Operaçoes Aritimeticas em 1 só!!");
                isfirst = false;
            }

            
                int dig1;
                Console.WriteLine("Primeiro digito: ");
                dig1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(dig1);

                int dig2;
                Console.WriteLine("Segundo digito: ");
                dig2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(dig2);
            


           



            Console.ReadLine();

        }
        
    }
}
