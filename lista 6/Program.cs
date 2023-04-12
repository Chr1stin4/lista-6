using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int ex;

            Console.WriteLine("menu");
            Console.WriteLine("exercício 1");
            Console.WriteLine("exercício 2");
            Console.WriteLine("exercício 3");
            Console.WriteLine("exercício 4");
            Console.WriteLine("exercício 5");
            Console.WriteLine("exercício 6");

            ex = int.Parse(Console.ReadLine());

            switch (ex)
            {
                case 1:
                    int quantidadeTotal = 0;
                    double precoTotal = 0;

                    if (true)
                    {
                        Console.Write("Digite a quantidade do produto: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        if (quantidade <= 0)
                        {
                            break;
                        }

                        Console.Write("Digite o preço do produto: ");
                        double preco = double.Parse(Console.ReadLine());

                        quantidadeTotal = quantidade;
                        precoTotal = quantidade * preco;
                    }

                    Console.WriteLine($"Total de itens adquiridos: {quantidadeTotal}");
                    Console.WriteLine($"Valor total da compra: R$ {precoTotal}");



                    break;

                    case 2:
                    string nomeProduto, nomeProdutoMaior = "", nome
                    int numeroproduto = 0, parada = 2;
                    double Preço, menorvalor, maiorvalor;

                    menorvalor = float.MaxValue;
                    maiorvalor = float.MinValue;    

                    for (;parada!=1; ) //laço de repetição infinito

                    { 
                        Console.WriteLine("Digite o nome do produto")
                        nome = Console.ReadLine();

                        Console.WriteLine("Digite a quantidade de produtos:");
                        numeroproduto = int.Parse(Console.ReadLine());

                        Console.WriteLine("Entre com o valor unitario:");
                        Preço = float.Parse(Console.ReadLine());

                  

                   

        }
    }
}

