using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine($"S - Segundos => 1s\nM - Minutos => 1m\n");
        Console.WriteLine($"0 - Sair");
        Console.WriteLine($"-------------\n");

        Console.WriteLine("Qual tempo deseja cronômetrar?");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1));
        double time = double.Parse(data.Substring(0, data.Length - 1));
        int multiplicador = 1;
        if (type == 'm')
            multiplicador = 60;
        if (time == 0)
        {
            Console.Clear();
            Console.WriteLine("Até mais...Volte sempre!");
            Thread.Sleep(2500);
            Console.Clear();
            System.Environment.Exit(0);
        }


        PreStart(time * multiplicador);
    }
    static void PreStart(double time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go..!!");
        Thread.Sleep(2500);

        Start(time);
    }
    static void Start(double time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);

        }
        Console.WriteLine("Stopwatch finalizando...");
        Thread.Sleep(2500);
        Menu();
    }
}
