namespace desafioDia6_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dia da Semana //////////////////////////////////////////////////////////////////////
            Console.WriteLine("\nInput a number from 1 to 7: ");
            int dia = int.Parse(Console.ReadLine());

            obterDiaDaSemana(dia);
        }

        static void obterDiaDaSemana(int dia)
        {
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
            }
        }
    }
}
