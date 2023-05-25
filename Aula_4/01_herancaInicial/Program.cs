internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p = new Pessoa("Matheus", 28);


        Console.WriteLine($"Detalhes de: {p.nome} -> idade: {p.idade}");
    }
}