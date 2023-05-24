using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Projeto_estudo
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int store_quantity { get; set; }

    }
    public class Store_product
    {
        public static void store_product(string User)
        {
            /*
                Sistema de gerenciamento de estoque de produtos:

                O sistema permite o gerenciamento de um estoque de produtos de uma empresa, incluindo o registro de novos produtos, a atualização das informações de produtos existentes, a consulta de produtos no estoque e a remoção de produtos.

                Funcionalidades básicas do sistema:

                Adicionar um produto ao estoque: solicitar informações sobre o nome do produto, quantidade, preço, etc.
                Editar informações de um produto: selecionar um produto existente e atualizar as informações necessárias.
                Consultar produtos no estoque: listar todos os produtos no estoque e permitir a busca de um produto por nome ou código.
                Remover um produto do estoque: selecionar um produto e removê-lo do estoque.
                Para implementar o sistema em C++, você pode usar uma variedade de recursos da linguagem, como estruturas, matrizes, funções e ponteiros. Aqui estão algumas dicas para começar:

                Use matrizes para armazenar informações sobre os produtos, como nome, quantidade e preço. Você pode criar uma matriz bidimensional para armazenar informações sobre vários produtos.
                Use estruturas para definir uma estrutura de dados que representa um produto, incluindo suas informações como nome, quantidade e preço.
                Crie funções para adicionar, editar, consultar e remover produtos do estoque. Certifique-se de passar as matrizes e estruturas apropriadas para as funções.
                Use ponteiros para manipular matrizes e estruturas e fazer a passagem de parâmetros entre as funções.
            */

            Console.WriteLine("Bem vindo " + User + " a sistema de gestão de produtos");

            select();


        }
        public static void select()
        {
            int selecao;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 1 | Adicionar Produtos [trabalhando]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 2 | Editar Produtos [Incompleto]");
            Console.WriteLine(" 3 | Consultar Produtos [Incompleto]");
            Console.WriteLine(" 4 | Remover Produto [Incompleto]");
            Console.ForegroundColor = ConsoleColor.White;

            selecao = int.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    add_products();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        public static void add_products()
        {
            string nome;
            decimal preco;
            int qtd_estoque;
            Console.Clear();
            Console.WriteLine("Tela Cadastro de Produtos");
            Console.WriteLine();

            Console.Write("Nome do Produto: ");
            nome = Console.ReadLine();
            Console.Write("Preco do Produto: ");
            preco = decimal.Parse(Console.ReadLine());
            Console.Write("Quantidade do Produto: ");
            qtd_estoque = int.Parse(Console.ReadLine());

            Product[] products = new Product[]
            {
                new Product { name = nome, price = preco, store_quantity = qtd_estoque }
            };            
            
            save_product(products);      
        }
        static void save_product(Product[] products)
        {

            string filePath = "products.json";
            string get_Path = Path.Combine(Directory.GetCurrentDirectory(), filePath);
            
            // Verificar se o arquivo já existe
            if (!File.Exists(get_Path))
            {
                // Criar o arquivo se ele não existir
                File.Create(get_Path).Close();
            }
            else
            {
                string jsonString = File.ReadAllText(filePath);
                JsonSerializer.Deserialize<Product[]>(jsonString);
            }
            
        }
    }
}


// o for é pq sei quantas vezes vou repetir

// while é pq não sei quantas vezes vai repetir