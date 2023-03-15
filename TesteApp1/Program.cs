namespace TesteApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            int idade = 30;
            int codigo = 1279;
            char genero = 'M';
            double preco1 = 102.87;
            double preco2 = 15.78;
            double medida = 52.92891;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1} cujo preço é {preco1}");
            Console.WriteLine($"{produto2} cujo preço é {preco2}");
            Console.WriteLine();
            Console.WriteLine($"Registro {idade} anos de idade, código {codigo}, e o gênero é: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com 8 casas decimais: {medida:F8}");
            Console.WriteLine($"Medida arredondada {medida:F3}");
        }
    }
}
