namespace TesteApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");

            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");

            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Seu nome é "+nome);
            Console.WriteLine("Você tem " + idade + " anos");

            double saldo = 10.897;

            Console.WriteLine($"{nome} tem {idade} e um saldo bancario de {saldo:F2}");
        }
    }
}
