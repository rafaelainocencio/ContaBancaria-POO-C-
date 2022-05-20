using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            ContaBancaria contaBancaria = new ContaBancaria(numConta, nome);

            Console.WriteLine("Haverá depósito inicial?(S/N)");
            char opcao = char.Parse(Console.ReadLine());
            if (opcao == 'S' || opcao == 's')
            {
                Console.Write("Entre o valor inicial: ");
                double valor = double.Parse(Console.ReadLine());
                contaBancaria.Depositar(valor);
            }

            Console.WriteLine("Dados atualizados: " + contaBancaria);

            int opcaoMenu = 9;

            do
            {
                Console.WriteLine("Digite sua opção");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Verificar saldo");
                Console.WriteLine("4 - Sair");

                opcaoMenu = int.Parse(Console.ReadLine());

                switch (opcaoMenu)
                {
                    case 1:
                        Console.Write("Entre um valor para depepósito: ");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        contaBancaria.Depositar(valorDeposito);
                        Console.WriteLine("Dados atualizados: " + contaBancaria);
                        break;
                    case 2:
                        Console.WriteLine("Entre um valor para saque(Taxa = R$5.00): ");
                        double valorSaque = double.Parse(Console.ReadLine());
                        contaBancaria.Sacar(valorSaque);
                        Console.WriteLine("Dados atualizados: " + contaBancaria);
                        break;
                    case 3:
                        Console.WriteLine(contaBancaria);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente!");
                        break;
                }
            } while (opcaoMenu != 4);
            Console.WriteLine("Volte sempre!");
        }
    }
}