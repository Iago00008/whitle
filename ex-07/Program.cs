class Program
{
    static void Main()
    {
        int contador = 10;

        Console.WriteLine("Contagem decrescente de 10 a 1:");
        while (contador >= 1)
        {
            Console.WriteLine(contador);
            contador = contador - 1;
        }
        contador = 1;

        Console.WriteLine("Contagem crescente de 1 a 10:");
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador = contador + 1;
        }
    }
}