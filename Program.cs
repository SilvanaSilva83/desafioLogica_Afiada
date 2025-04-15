namespace dia8_part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double totalVendas = 0;
            string status;
            bool entradaValida;// Variável para controlar a entrada válida do usuário

            object[,] checkoutSupermarket = new object[3, 3];

            // Preenchendo a matriz com os dados - Lista de checkouts e seus respectivos clientes

            for (int i = 0; i <checkoutSupermarket.GetLength(0);i++)
            { 
                do
                {               
                    Console.Write($"Informe numero do Checkout | 1 | 2 | 3 \t");
                    checkoutSupermarket[i, 0] = Console.ReadLine();
                    switch(checkoutSupermarket[i, 0])
                    {
                        case "1":
                            checkoutSupermarket[i, 0] = "CheckOut 1";
                            entradaValida = true; // Entra da válida, sai do loop
                            break;
                        case "2":
                            checkoutSupermarket[i, 0] = "CheckOut 2";
                            entradaValida = true; 
                            break;
                        case "3":
                            checkoutSupermarket[i, 0] = "CheckOut 3";
                            entradaValida = true; 
                            break;
                        default:
                            Console.WriteLine("Número inválido. Tente novamente.");
                            entradaValida = false; // Continua pedindo uma entrada válida
                            break;
                    }

                } while (!entradaValida); // Loop até receber uma entrada válida

                Console.Write($"Digite nome do cliente: \t\t");                
                checkoutSupermarket[i, 1] = Console.ReadLine();

                do
                { 
                    Console.Write($"Digite o valor de vendas: \t\t");
                    if (double.TryParse(Console.ReadLine(), out double checkoutValue))
                    {
                        checkoutSupermarket[i, 2] = checkoutValue;
                        entradaValida = true;// Entra da válida, sai do loop
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Tente novamente.");
                        entradaValida = false;// Continua pedindo uma entrada válida
                    }
                    Console.WriteLine();

                } while (!entradaValida);// Loop até receber uma entrada válida
            }

            Console.WriteLine(" CheckOut     | Tipo de Cliente | Vendas (€) ");
            Console.WriteLine("----------------------------------------------");
            
            // Exibindo os valores da matriz
            for (int i = 0; i < checkoutSupermarket.GetLength(0); i++)
            {
                for (int j = 0; j < checkoutSupermarket.GetLength(1); j++)
                {
                    Console.Write(checkoutSupermarket[i, j] + "\t\t");
                }

                totalVendas += Convert.ToDouble(checkoutSupermarket[i, 2]+"\t"); // Somando os valores da coluna de vendas (posição [i, 2])

                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Total de vendas: \t\t€ {totalVendas:0.00}");

            // Lista de checkouts e status de atendimento dos clientes


            Console.WriteLine(" Cliente     | Vendas (€) | Status de Atendimento ");
            Console.WriteLine("----------------------------------------------");

            int contadorAtendimento = checkoutSupermarket.GetLength(0);  // Contador para controlar o atendimento dos clientes

            for (int i = 0; i < checkoutSupermarket.GetLength(0); i++)
            {
                contadorAtendimento--; // Decrementa o contador a cada atendimento

                if (contadorAtendimento >= 1) //1º cliente atendido
                    status = "Atendido";
                else
                    status = "Em espera"; // Último cliente
                
                Console.WriteLine($"{checkoutSupermarket [i,1]}\t | \t{checkoutSupermarket[i, 2]:0.00} | \t{status}");
            }
        }
    }
}
