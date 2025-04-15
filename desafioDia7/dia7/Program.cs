using System.ComponentModel;

namespace dia7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Declaração de variaveis
            double Bradesco_cc, Bradesco_cp, Bradesco, limite, transferencia, debito, deposito, saldo, valor;
            string nomeCliente, saldoInsuficiente = "Gentileza, verificar transacao,saldo insuficiente";
            double limiteNormal = 0.10, limiteEspecial = 0.15, limitePercent, totalDisponivelBanco, totalDisponivelCC, totalDisponivelCP;


            // Menu Inicial
            Console.WriteLine("Menu Principal");
            Console.WriteLine("\n________________________________________________\n");

            Console.Write("Bem-vindo ao Bradesco!\nDigite o seu nome: ");
            nomeCliente = Console.ReadLine();

            Console.Write("Informe o saldo da Conta Corrente: ");
            Bradesco_cc = double.Parse(Console.ReadLine());

            Console.Write("Informe o saldo da Conta Poupança: ");
            Bradesco_cp = double.Parse(Console.ReadLine());            

            // Calculo do saldo total e limite
            Bradesco = Bradesco_cc + Bradesco_cp;            
            limite = Bradesco * limiteNormal;
            if(Bradesco >= 1000)
            {
                limitePercent = 0.10;                ;
            }
            else
            {
                limitePercent = 0;                
            }
            
            totalDisponivelBanco = Bradesco + (Bradesco*limitePercent);
            totalDisponivelCC = Bradesco_cc+(Bradesco_cc*limitePercent);
            totalDisponivelCP = Bradesco_cp+(Bradesco_cp*limitePercent);

            Console.Write("Saldo Total: ");
            Console.WriteLine(totalDisponivelBanco);

            // Extrato bancario
            Console.WriteLine("\n________________________________________________\n");
            Console.WriteLine("\nExtrato Brancario\n");
            Console.WriteLine("\n________________________________________________\n");
            Console.WriteLine($"Ola, {nomeCliente}.\n\n" +
                $"Saldo C.C Bradesco: {Bradesco_cc:0.00} | Limite C.Especial: {Bradesco_cc*limitePercent:0.00} | Saldo Disponivel: {totalDisponivelCC:0.00} \n" +
                $"Saldo C.Poupranca Bradesco {Bradesco_cp:0.00} | Limite C.Especial: {Bradesco_cp *limitePercent:0.00} | Saldo Disponivel: {totalDisponivelCP:0.00}\n" +
                $"Saldo Total: {Bradesco:0.00}\n" +
                $"Limite Cheque Especial: {limite}\n" +
                $"Total Disponivel: {totalDisponivelBanco:0.00}");

            // Menu de operacoes
            while (true)
            {
                Console.WriteLine("\nEm que podemos ajudar?\n1 - Transferencia\n2 - Deposito\n3 - Efetuar pagamento\n4 - Conversao\n5 - Extrato Atualizado\n0 - Voltar ao Menu Principal");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Transferencia(ref Bradesco_cc, ref Bradesco_cp);
                }
                else if (opcao == 2)
                {
                    Deposito(ref Bradesco_cc, ref Bradesco_cp);
                }
                else if (opcao == 3)
                {
                    EfetuarPagamento(ref Bradesco_cc, ref Bradesco_cp);
                }
                else if (opcao == 4)
                {
                    Conversao(ref Bradesco_cc, ref Bradesco_cp);
                }
                else if (opcao == 5)
                {
                    ExibirSaldo(nomeCliente, Bradesco_cc, Bradesco_cp, Bradesco, limite, limitePercent, totalDisponivelCC, totalDisponivelCP, totalDisponivelBanco);
                }
                else if (opcao == 0)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break; // Interrompe o loop e sai do programa
                }
                else
                {
                    Console.WriteLine("Opcao invalida.");
                }

            }
            
        }

        static void Transferencia(ref double Bradesco_cc,ref double Bradesco_cp)
        {
            while (true)
            {
                Console.WriteLine("Conta a ser debitada? 1 - Conta Corrente / 2 - Conta Poupanca");
                int conta = int.Parse(Console.ReadLine());            
                if (conta == 1)
                {
                    Console.WriteLine("Transacao de C.Corrente >> para >> C.Poupanca | Qual o valor da transferencia?");
                    double transferencia = double.Parse(Console.ReadLine());

                    if (Bradesco_cc < transferencia)
                    {
                        Console.WriteLine("Saldo insuficiente.");                        
                    }
                    else
                    {
                        Bradesco_cc -= transferencia;
                        Bradesco_cp += transferencia;
                        Console.WriteLine($"Transferencia realizada com sucesso!\n" +
                            $"Novo saldo da Conta Corrente: {Bradesco_cc}\n" +
                            $"Novo saldo da Conta Poupanca: {Bradesco_cp}"); 
                    }
                }
                else if (conta == 2)
                {
                    Console.WriteLine("Transacao de C.Poupanca >> para >> C.Corrente | Qual o valor da transferencia?");
                    double transferencia = double.Parse(Console.ReadLine());
                    if (Bradesco_cp < transferencia)
                    {
                        Console.WriteLine("Saldo insuficiente.");
                    }
                    else
                    {
                        Bradesco_cp -= transferencia;
                        Bradesco_cc += transferencia;
                        Console.WriteLine($"Transferencia realizada com sucesso!\n" +
                        $"Novo saldo da Conta Poupanca: {Bradesco_cp}\n" +
                        $"Novo saldo da Conta Corrente: {Bradesco_cc}");
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }

                Console.WriteLine("Deseja realizar outra transacao? (s/n)");
                bool continuar = Console.ReadLine().ToLower() == "s";
                if (!continuar)
                {
                    Console.WriteLine("Saindo do sistema...");
                    return; // Interrompe o loop e retorna ao menu principal
                }
            }

        }

        static void Deposito(ref double Bradesco_cc, ref double Bradesco_cp)
        {
            Console.WriteLine("Qual o valor do desposito?");
            double desposito = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a conta para deposito? 1 - Conta Corrente / 2 - Conta Poupanca");
            int conta = int.Parse(Console.ReadLine());

            if (conta == 1)
            {                
                Bradesco_cc += desposito;
                Console.WriteLine($"Transferencia realizada com sucesso! Novo saldo da Conta Corrente: {Bradesco_cc}");
            }
            else if (conta == 2)
            {                
                Bradesco_cp += desposito;                    
                Console.WriteLine($"Transferencia realizada com sucesso! Novo saldo da Conta Poupanca: {Bradesco_cp}");               
            }
            else
            {
                Console.WriteLine("Opcao invalida.");
            }
        }

        static void EfetuarPagamento(ref double Bradesco_cc, ref double Bradesco_cp)
        {
            Console.WriteLine("Qual o valor do pagamento?");
            double debito = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a conta a ser debitado o pagarmento? 1 - Conta Corrente / 2 - Conta Poupanca");
            int conta = int.Parse(Console.ReadLine());

            if (conta == 1)
            {
                if (Bradesco_cc >= debito)
                {
                    Bradesco_cc -= debito;
                    Console.WriteLine($"Pagamento realizado com sucesso! Novo saldo da Conta Corrente: {Bradesco_cc}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
            else if (conta == 2)
            {
                if (Bradesco_cp >= debito)
                {
                    Bradesco_cp -= debito;
                    Console.WriteLine($"Pagamento realizado com sucesso! Novo saldo da Conta Poupanca: {Bradesco_cp}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
            else
            {
                Console.WriteLine("Opcao invalida.");
            }
        }

        static void Conversao(ref double Bradesco_cc, ref double Bradesco_cp)
        {
            double dolar = 5.25; // Exemplo de valor do dólar
            double euro = 6.00; // Exemplo de valor do euro
            double libra = 7.00; // Exemplo de valor da libra
            double cambio = 0;
            char currency = ' '; // Inicializa a variável currency

            char dolar_c = '$', euro_c = '€', libra_c='£';

            Console.WriteLine("Escolha a moeda que deseja converter?");
            Console.WriteLine("1 - Dolar\n2 - Euro\n3 - Libra");
            double moeda = int.Parse(Console.ReadLine());
            switch(moeda)
            {
                case 1:
                    Console.WriteLine($"Valor em Dolar: {dolar}");
                    moeda = dolar;
                    currency = dolar_c;
                    break;
                case 2:
                    Console.WriteLine($"Valor em Euro: {euro}");
                    moeda = euro;
                    currency = euro_c;
                    break;
                case 3:
                    Console.WriteLine($"Valor em Libra: {libra}");
                    moeda = libra;
                    currency = libra_c;
                    break;
                default:
                    Console.WriteLine("Opcao invalida.");
                    break;
            }

            Bradesco_cc = Bradesco_cc / moeda;
            Bradesco_cp = Bradesco_cp / moeda;
            Console.WriteLine($"Conversao Real para {moeda} realizada com sucesso! Valor em {moeda} Conta Corrente: {currency}{Bradesco_cc:0.00}");
            Console.WriteLine($"Conversao Real para {moeda} realizada com sucesso! Valor em {moeda} Conta Poupanca: {currency}{Bradesco_cp:0.00}");
           
        }

        static void ExibirSaldo(string nomeCliente, double Bradesco_cc, double Bradesco_cp, double Bradesco, double limite, double limitePercent, double totalDisponivelCC, double totalDisponivelCP, double totalDisponivelBanco)
        {    
            Console.WriteLine($"\nOla, {nomeCliente}. Segue abaixo o seu extrato bancario\n");
            Console.WriteLine("\n________________________________________________\n");
            Console.WriteLine("\nExtrato Brancario\n");
            Console.WriteLine("\n________________________________________________\n");
            Console.WriteLine($"Ola, {nomeCliente}.\n\n" +
                $"Saldo C.C Bradesco: {Bradesco_cc:0.00} | Limite C.Especial: {Bradesco_cc * limitePercent:0.00} | Saldo Disponivel: {totalDisponivelCC:0.00} \n" +
                $"Saldo C.Poupranca Bradesco {Bradesco_cp:0.00} | Limite C.Especial: {Bradesco_cp * limitePercent:0.00} | Saldo Disponivel: {totalDisponivelCP:0.00}\n" +
                $"Saldo Total: {Bradesco:0.00}\n" +
                $"Limite Cheque Especial: {limite}\n" +
                $"Total Disponivel: {totalDisponivelBanco:0.00}");
        }
    }
}
