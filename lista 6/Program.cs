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
                        Console.Write("Digite a quantidade do produto: 
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

                    for (; parada != 1;) //laço de repetição infinito

                    {
                        Console.WriteLine("Digite o nome do produto")
                        nome = Console.ReadLine();

                        Console.WriteLine("Digite a quantidade de produtos:");
                        numeroproduto = int.Parse(Console.ReadLine());

                        Console.WriteLine("Entre com o valor unitario:");
                        Preço = float.Parse(Console.ReadLine());

                        float total = Numerodeitenstotal
                            * Preçodoproduto;
                        if (total < )

                            Console.WriteLine("\ncadastro de produtos encerrado");
                        break;

                
                        
                        Console.Write("Digite o número de avaliações que você planeja oferecer: ");
                int numAvaliacoes = int.Parse(Console.ReadLine());

                float somaPesos = 0;

                for (int i = 1; i <= numAvaliacoes; i++)
                {
                    Console.Write($"Digite o peso da {i}ª avaliação: ");
                    float peso = float.Parse(Console.ReadLine());

                    somaPesos += peso;
                }

                if (somaPesos < 100)
                {
                    Console.WriteLine($"A soma total dos pesos é insuficiente: {somaPesos}%");
                }
                else if (somaPesos > 100)
                {
                    Console.WriteLine($"A soma total dos pesos é excedente: {somaPesos}%");
                }
                else
                {
                    Console.WriteLine($"A soma total dos pesos é adequada: {somaPesos}%");

                    break;

                        Console.Write("Digite a sigla do estado: ");
                        string sigla = Console.ReadLine().ToUpper();

                        switch (sigla)
                        
                            case "AC":
                                Console.WriteLine("Acre");
                                break;
                            case "AL":
                                Console.WriteLine("Alagoas");
                                break;
                            case "AP":
                                Console.WriteLine("Amapá");
                                break;
                            case "AM":
                                Console.WriteLine("Amazonas");
                                break;
                            case "BA":
                                Console.WriteLine("Bahia");
                                break;
                            case "CE":
                                Console.WriteLine("Ceará");
                                break;
                            case "DF":
                                Console.WriteLine("Distrito Federal");
                                break;
                            case "ES":
                                Console.WriteLine("Espírito Santo");
                                break;
                            case "GO":
                                Console.WriteLine("Goiás");
                                break;
                            case "MA":
                                Console.WriteLine("Maranhão");
                                break;
                            case "MT":
                                Console.WriteLine("Mato Grosso");
                                break;
                            case "MS":
                                Console.WriteLine("Mato Grosso do Sul");
                                break;
                            case "MG":
                                Console.WriteLine("Minas Gerais");
                                break;
                            case "PA":
                                Console.WriteLine("Pará");
                                break;
                            case "PB":
                                Console.WriteLine("Paraíba");
                                break;
                            case "PR":
                                Console.WriteLine("Paraná");
                                break;
                            case "PE":
                                Console.WriteLine("Pernambuco");
                                break;
                            case "PI":
                                Console.WriteLine("Piauí");
                                break;
                            case "RJ":
                                Console.WriteLine("Rio de Janeiro");
                                break;
                            case "RN":
                                Console.WriteLine("Rio Grande do Norte");
                                break;
                            case "RS":
                                Console.WriteLine("Rio Grande do Sul");
                                break;
                            case "RO":
                                Console.WriteLine("Rondônia");
                                break;
                            case "RR":
                                Console.WriteLine("Roraima");
                                break;
                            case "SC":
                                Console.WriteLine("Santa Catarina");
                                break;
                            case "SP":
                                Console.WriteLine("São Paulo");
                                break;
                            case "SE":
                                Console.WriteLine("Sergipe");
                                break;
                            case "TO":
                                Console.WriteLine("Tocantins");
                                break;
                            default:
                                Console.WriteLine("Sigla inválida!");
                                break;

                         Console.Write("Digite o número do mês (1 a 12): ");
                         int mes = int.Parse(Console.ReadLine());

                        switch (mes)
                                    {
                         case 1:
                         case 2:
                         case 12:
                         Console.WriteLine("Estação: Verão");
                         break;

                         case 3:
                         case 4:
                         case 5:
                         Console.WriteLine("Estação: Outono");
                         break;

                         case 6:
                         case 7:
                         case 8:
                         Console.WriteLine("Estação: Inverno");
                         break;

                         case 9:
                         case 10:
                         case 11:
                         Console.WriteLine("Estação: Primavera");
                         break;

                         default:
                            Console.WriteLine("Mês inválido!");
                            break;
                                    }

                        if (mes == 3 || mes == 6 || mes == 9 || mes == 12)
                                    {
                        Console.Write("Digite 'N' para Outono ou 'P' para Primavera: ");
                        char escolha = char.Parse(Console.ReadLine().ToUpper());

                        switch (escolha)
                                        {
                         case 'N':
                         Console.WriteLine("Estação: Outono");
                         break;

                        case 'P':
                        Console.WriteLine("Estação: Primavera");
                         break;

                         default:
                        Console.WriteLine("Escolha inválida!");
                         break;

                         Console.Write("Digite seu peso (em kg): ");
                         double peso = double.Parse(Console.ReadLine());

                         Console.Write("Digite sua altura (em metros): ");
                            double altura = double.Parse(Console.ReadLine());

                        double imc = peso / (altura * altura);
                        Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

                        if (imc < 18.5)
                        {
                        Console.WriteLine("Você está abaixo do peso.");
                         }
                         else if (imc >= 18.5 && imc <= 24.9)
                         {
                         Console.WriteLine("Seu peso está normal.");
                         }
                         else if (imc >= 25.0 && imc <= 29.9)
                         {
                         Console.WriteLine("Você está com sobrepeso.");
                         }
                         else if (imc >= 30.0 && imc <= 34.9)
                         {
                         Console.WriteLine("Você está com obesidade grau 1.");
                         }
                         else if (imc >= 35.0 && imc <= 39.9)
                         {
                         Console.WriteLine("Você está com obesidade grau 2.");
                         }
                         else
                         {
                         Console.WriteLine("Você está com obesidade grau 3 (mórbida).");
                         break;

                         Console.Write("Digite um número inteiro positivo: ");
                         int num = int.Parse(Console.ReadLine());

                         Console.Write("Divisores de " + num + ": ");
                        for (int i = 1; i <= num; i++)
                                                {
                        if (num % i == 0)
                                                    {
                        Console.Write(i + " ");

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

