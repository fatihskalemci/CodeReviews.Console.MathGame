namespace mathGame.fatihskalemci;

internal class Helpers
{
    internal static int getUserAnswer()
    {
        string? userInput = Console.ReadLine();

        while (string.IsNullOrEmpty(userInput) || !Int32.TryParse(userInput, out _))
        {
            Console.WriteLine("Answer needs to be an integer. Try again");
            userInput = Console.ReadLine();

        }
        return int.Parse(userInput);
    }
}
