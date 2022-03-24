namespace RpgGame.Service;

public class IO
{
    public static Queue<string> Buffer { get; set; } = new Queue<string>();

    public static void Out(string message, bool clear = false)
    {
        if (clear)
            Console.Clear();

        Console.WriteLine(message);
    }

    private static string ReadLine()
    {
        if (Buffer.Count > 0)
            return Buffer.Dequeue();
        
        return Console.ReadLine()!;
    }

    public static int IntIn(string message, bool clear = false)
    {
        if (clear)
            Console.Clear();

        while (true)
        {
            Console.Write(message);
            var input = ReadLine();

            if (int.TryParse(input, out int result))
            {
                return result;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Du måste ange ett nummer..");
            Console.WriteLine("Testa [1] eller [2]....");
            Console.ResetColor();
        }
    }

    public static string StringIn(string message, bool clear = false)
    {
        if (clear)
            Console.Clear();

        while (true)
        {
            Console.Write(message);
            var input = ReadLine();

            if (input != null)
                return input;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Du måste ange en sträng..");
            Console.ResetColor();
        }
    }

    public static void AnyIn(string message, bool clear = false)
    {
        if (clear)
            Console.Clear();

        Console.Write(message);
        Console.ReadLine();
    }
}