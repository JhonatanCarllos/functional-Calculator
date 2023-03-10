internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine($"Bem vindo Calculadora 1.0 C#\n");
        Console.WriteLine($"1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n0 - Sair");
        Console.WriteLine("-------------------");
        Console.WriteLine($"\nEscolha a operação que deseja:");
        short operacao = short.Parse(Console.ReadLine());

        switch (operacao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 0: Sair(); break;
            default: Menu(); break;

        }
    }
    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Calculadora 1.0 C#");

        Console.WriteLine("");

        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 + v2;
        Console.WriteLine($"O resultado da soma é {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("Calculadora 1.0 C#");

        Console.WriteLine("");

        Console.WriteLine("Primeiro valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        double v2 = double.Parse(Console.ReadLine());

        double resultado = v1 - v2;

        Console.WriteLine("");

        Console.WriteLine($"O resultado da subtração é {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Calculadora 1.0 C#");

        Console.WriteLine("");

        Console.WriteLine("Primeiro Valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = v1 / v2;

        Console.WriteLine($"O resultado da divisão é {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Calculadora 1.0 C#");

        Console.WriteLine("");

        Console.WriteLine("Primeiro valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor:");
        double v2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        double resultado = v1 * v2;

        Console.WriteLine($"O resultado da multiplicação é {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Sair()
    {
        Console.Clear();
        Console.WriteLine($"Agradecemos pela preferência, deixe seu feadback no privado!\n\nVolte sempre...");
        Console.ReadKey();
        Console.Clear();
        System.Environment.Exit(0);
    }
}