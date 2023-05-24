
using Prototype_MyFinanc_Menu;

namespace Prototype_MyFinanc_Login
{

    public class Login
    {
        static int selecGlobal=0;
        const string UserGlobal = "Admin";
        const string PasswordGlobal = "Adm123";
        
        public static void Welcome()
        {
            
            Console.WriteLine("Bem vindo ao MyFinanc\n'pressione {Enter} para iniciar'");
            Console.ReadLine();
            repete:
            Console.Clear();
            Console.WriteLine("MyFinanc - Login\n");
            Console.WriteLine("Digite o numero para selecionar a sua ação");
            Console.WriteLine("1 - Login\n2 - Criar Conta");
            selecGlobal = int.Parse(Console.ReadLine());

            switch (selecGlobal)
            {
                case 1:
                    LoginProfile();
                    break;


                case 2:
                    LoginProfile();
                    break;


                default:
                    Console.WriteLine("Valor Incorreto\n'pressione {Enter}'");
                    Console.ReadLine();
                    goto repete;
                
            }

        }

        public static void LoginProfile()
        {
            string UserLocal, PasswordLocal;
            Console.Clear();
            Console.WriteLine("MyFinanc - LoginProfile\n");
            Console.Write("Usuario: ");
            UserLocal = Console.ReadLine();
            Console.Write("Senha: ");
            PasswordLocal = Console.ReadLine();

            // Verificador
            if (UserLocal == UserGlobal && PasswordLocal == PasswordGlobal)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login Aprovado");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" 'pressione {Enter} para continuar' ");
                Console.ReadLine();
                Menu.Interface(UserGlobal);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usuario ou Senha Incorreto");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("'pressione {Enter}'");
                Console.ReadLine();
                LoginProfile();
            }
        }
        public static void CreateProfile()
        {

        }
    }
}
