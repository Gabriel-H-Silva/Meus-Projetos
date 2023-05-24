using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype_MyFinanc.salary;

namespace Prototype_MyFinanc_Menu
{
    public class Menu
    {
        static int selecGlobal = 0;
        public static void Interface(string UserGlobal) 
        {
            repete:
            Console.Clear();
            Console.WriteLine("MyFinanc - Menu\n");
            Console.WriteLine("Olá {0} o que vamos fazer Hoje?", UserGlobal);

            Console.WriteLine("1 - Salario\n2 - Contas");
            selecGlobal = int.Parse(Console.ReadLine());
            switch (selecGlobal)
            {
                case 1:
                    Salarios_select(UserGlobal);
                    break;


                case 2:
                    break;


                default:
                    Console.WriteLine("Valor Incorreto\n'pressione {Enter}'");
                    Console.ReadLine();
                    Console.Clear();
                    goto repete;

            }

        }

        public static void Salarios_select(string UserGlobal) 
        {
            Console.Clear();
            repete:
            Console.WriteLine("1 - Adicionar Salario Bruto\n2 - Editar Salario\n0 - Voltar para o Menu...");
            selecGlobal = int.Parse(Console.ReadLine());
            switch (selecGlobal)
            {
                case 0:
                    Interface(UserGlobal);
                    break;

                case 1:
                    Salarios_select(UserGlobal);
                    break;


                case 2:
                    break;


                default:
                    Console.WriteLine("Valor Incorreto\n'pressione {Enter}'");
                    Console.ReadLine();
                    Console.Clear();
                    goto repete;

            }

        }
    }
}
