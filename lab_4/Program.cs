namespace Lab4;
class Program
{
    static void Main(string[] args)
    {
        ContaCorrente minhaConta = new ContaCorrente(340); 
        Console.WriteLine(minhaConta.Saldo); 
        minhaConta.Depositar(100); 
        Console.WriteLine(minhaConta.Saldo); 
        minhaConta.Sacar(50); 
        Console.WriteLine(minhaConta.Saldo);
    }
}