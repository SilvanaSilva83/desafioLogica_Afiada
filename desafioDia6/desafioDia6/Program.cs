using System.Xml.Linq;

namespace desafioDia6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IMC //////////////////////////////////////////////////////////////////////
            string name;
            double weights, height = 0;

            //Input
            Console.Write("Input your name: ");
            name = Console.ReadLine();

            Console.Write("Input your weights: ");
            weights = double.Parse(Console.ReadLine());

            Console.Write("Input your height: ");
            height = double.Parse(Console.ReadLine());           

            //Output
            Console.WriteLine($"\nHello {name}. Your IMC is: "+ DesafioIMC(weights, height));     
        }

        static double DesafioIMC(double weights, double height)
        {
            //Declare
            double imc=0;

            //Process
            imc = (weights / (height * height));

            return Math.Round(imc, 2); // Round to 2 decimal places            
        }

    }

}
