using System.Diagnostics;

namespace dia9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] carrosRankings = new string[10] { "FIAT STRADA", "VOLKSWAGEN POLO", "CHEVROLET ONIX", "HYUNDAI HB20", "FIAT ARGO", "VOLKSWAGEN T - CROSS", "CHEVROLET TRACKE", "HYUNDAI CRETA", "FIAT MOBI", "NISSAN KICKS"};

            // TOP 5 >>> IndexOf 0 to 4
            string[] cincoPrimeiros = carrosRankings[..5]; // Slicing the first 5 elements
            Console.WriteLine("Slicing the first 5 element");
            Console.WriteLine(string.Join(",\n ", cincoPrimeiros));
            Console.WriteLine();

            //Contain >> includes
            bool contem = false;
            string pesquisa;

            Console.WriteLine("Informe um carro que deseja pesquisar");
            pesquisa = Console.ReadLine();
            contem = carrosRankings.Contains(pesquisa);
            string mensagem = carrosRankings.Contains(pesquisa)? "Carro encontrado!" : "Carro NÃO encontrado!"; // Ternary operator

            Console.WriteLine(mensagem);

            //lastOf
            Console.WriteLine("Ultimos 5 carros");
            string[] ultimosCinco = carrosRankings[^5..]; // Slicing the last 5 elements
            Console.WriteLine(string.Join(",\n ", ultimosCinco));



            string[] cincoUltimos = carrosRankings[10..]; // Slicing from the 10th element to the end
            Console.WriteLine("Slicing from the 10th element to the end");
            Console.WriteLine(string.Join(",\n ", cincoUltimos));
            Console.WriteLine();

            string[] cincoUltimos2 = carrosRankings[2..5]; // Slicing from the 3rd to the 5th element
            Console.WriteLine("Slicing from the 3rd to the 5th element");
            Console.WriteLine(string.Join(",\n ", cincoUltimos2));
            Console.WriteLine();


            string[] cincoUltimos3 = carrosRankings[15..^5]; // Slicing from the 15rd element to the 2nd last element
            Console.WriteLine("Slicing from the 15rd element to the 5th last element");
            Console.WriteLine(string.Join("\n ", cincoUltimos3));
            Console.WriteLine();

            Console.WriteLine(string.Join(",\n ", cincoPrimeiros));
            Console.WriteLine(string.Join(",\n ", cincoUltimos));

        }
    }
}
