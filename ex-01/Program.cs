class Program
{
    static void Main()
    {
        string frase = "Esta frase será impressa 10 vezes em C#.";
        int contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine(frase);
            contador = contador + 1;
        }
    }
}