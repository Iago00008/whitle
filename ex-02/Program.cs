class Program
{
    static void Main()
    {
        Console.Write("Digite um número N:");
        int N = int.Parse(Console.ReadLine());

        int contador = 1;

        while (contador <= N)
        {
            Console.WriteLine(contador);
            contador = contador + 1;
        }
    }
}
