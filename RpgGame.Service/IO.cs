namespace RpgGame.Service;

public class IO
{
    public void Out(string message, bool clear)
    {
        if (clear)
            Console.Clear();

        Console.WriteLine(message);
    }

    public int IntIn(string message, bool clear)
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
            Console.WriteLine("Du måste ange ett nummer..... ");
            Console.ResetColor();
        }
    }

    public string StringIn(string message, bool clear)
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
            Console.WriteLine("Du måste ange en sträng....");
            Console.ResetColor();
        }
    }
}