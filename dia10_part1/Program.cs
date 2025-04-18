namespace dia10_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
                        
            string[] livros3 = { "Use a cabeça: Padrões de Projeto", "Expressões Regulares: Uma Abordagem Divertida", "O Programador Apaixonado", "Refatoração: Aperfeiçoando o Design de Códigos Existentes", "Código Limpo: Habilidades Práticas do Agile Software", "Trabalho Eficaz com Código Legado", "Padrões de Projeto: Soluções Reutilizáveis de Software Orientado à Objetos", "Domain Driven Design: Atacando as Complexidades no Coração do Software", "O Mítico Homem - Mês: Ensaios Sobre Engenharia de Software", "Padrões de Arquitetura de Aplicações Corporativas","Algoritmos e Lógica de Programação", "Código Limpo: Habilidades Práticas do Agile Software", "O Programador Pragmático: De Aprendiz a Mestre", "Refatoração: Aperfeiçoando o Design de Códigos Existentes", "Trabalho Eficaz com Código Legado", "Padrões de Projeto: Soluções Reutilizáveis de Software Orientado a Objetos", "Introdução à Algoritmos", "Algoritmos: Teoria e Prática", "Design de Algoritmos", "Entendendo Estruturas de Dados e Algoritmos" };


            Stack<string> bookBox1 = new Stack<string>();
            Stack<string> bookBox2 = new Stack<string>();

            

            // Empilhando os livros
            foreach (string book in livros3)
            {
                if (bookBox1.Count < 10)
                {
                    bookBox1.Push(book);
                }
                else
                {
                    bookBox2.Push(book);
                }

            }

            //Quando a pilha estiver cheia, empacota o livro na caixa B
            if (bookBox1.Count >= 10)
            {
                Console.WriteLine("Caixa \"A\" com 10 Livros. Pacote envaido para fechar");
            }
                        
            // Exibindo os livros empilhados
            Console.WriteLine("\n📦 Livros Empacotados na Caixa A:");
            foreach (var book in bookBox1)
            {
                Console.WriteLine("\t"+book);
            }

            if (bookBox2.Count >= 10)
            {
                Console.WriteLine("Caixa \"B\" com 10 Livros. Pacote envaido para fechar");
            }

            Console.WriteLine("\n📦 Livros Empacotados na Caixa B:");
            foreach (var book in bookBox2)
            {
                Console.WriteLine("\t" + book);
            }

                       
            
        }
    }
}
