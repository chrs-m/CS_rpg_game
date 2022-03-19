namespace RpgGame.Service;

public class IO
{
    public static void Out(string message, bool clear = false)
    {
        if (clear)
            Console.Clear();

        Console.WriteLine(message);
    }

    public static int IntIn(string message, bool clear = false)
    {
        if (clear)
            Console.Clear();

        while (true)
        {
            Console.Write(message);
            var input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                return result;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Du måste ange ett nummer..");
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
            var input = Console.ReadLine();

            if (input != null)
                return input;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Du måste ange en sträng..");
            Console.ResetColor();
        }
    }
}