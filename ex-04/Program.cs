class Program
{
    static void Main()
    {
        Console.Write("Digite um número N: ");
        int N = int.Parse(Console.ReadLine());

        int numero = 2;

        while (numero <= N)
        {
            Console.WriteLine(numero);
            numero = numero + 2;
        }
    }
}