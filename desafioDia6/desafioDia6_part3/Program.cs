namespace desafioDia6_part3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Aplicacao Financeira ////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nAplicacao Financeira");


            Console.WriteLine("Digite o valor inicial do investimnto: ");
            double investimentoInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tempo de investimento em anos: ");
            int tempo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a taxa de juros: ");
            double taxaJuros = double.Parse(Console.ReadLine());

            double rendimentoFinal = AplicacaoFinanceira(investimentoInicial, tempo, taxaJuros);
            Console.WriteLine($"O rendimento final será de: {rendimentoFinal:0.00} reais.");
        }

        static double AplicacaoFinanceira(double investimentoInicial, int tempo, double taxaJuros)
        {
            int ano = 1;
            double rendimentoFinal;

            for (ano = 1; ano <= tempo; ano++)
            {
                investimentoInicial += investimentoInicial * (taxaJuros / 100);
            }

            return rendimentoFinal = investimentoInicial;
            //Output


        }
    }
}
