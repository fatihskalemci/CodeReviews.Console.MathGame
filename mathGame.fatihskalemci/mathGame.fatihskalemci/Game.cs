
using System.Drawing;

namespace mathGame.fatihskalemci
{
    internal class Game
    {

        public List<string> history { get; set; } = new List<string>();

        internal int AdditionGame()
        {
            Random random = new();
            int firstNumber = random.Next(1, 100);
            int secondNumber = random.Next(1, 100);
            Console.Clear();
            Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
            int result = firstNumber + secondNumber;
            int answer = Helpers.getUserAnswer();
            int point = ValidateAnswer(answer, result, firstNumber, secondNumber, '+');
            return point;

        }

        internal int DivisionGame()
        {
            Random random = new();
            int firstNumber = random.Next(1, 100);
            int secondNumber = random.Next(1, 100);
            while(firstNumber%secondNumber != 0)
            {
                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(1, 100);
            }
            Console.Clear();
            Console.WriteLine($"{firstNumber} / {secondNumber} = ?");
            int result = firstNumber / secondNumber;
            int answer = Helpers.getUserAnswer();
            int point = ValidateAnswer(answer, result, firstNumber, secondNumber, '/');
            return point;
        }

        internal int MultiplicationGame()
        {
            Random random = new();
            int firstNumber = random.Next(1, 100);
            int secondNumber = random.Next(1, 100);
            Console.Clear();
            Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
            int result = firstNumber * secondNumber;
            int answer = Helpers.getUserAnswer();
            int point = ValidateAnswer(answer, result, firstNumber, secondNumber, '*');
            return point;
        }

        internal int SubtractionGame()
        {
            Random random = new();
            int firstNumber = random.Next(1, 100);
            int secondNumber = random.Next(1, 100);
            Console.Clear();
            Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
            int result = firstNumber - secondNumber;
            int answer = Helpers.getUserAnswer();
            int point = ValidateAnswer(answer, result, firstNumber, secondNumber, '-');
            return point;
        }

        internal int RandomGame()
        {
            Random random = new();
            int gameSelection = random.Next(0, 4);
            int point =0;
            switch (gameSelection)
            {
                case 0:
                    point = AdditionGame();
                    break;
                case 1:
                    point = SubtractionGame();
                    break;
                case 2:
                    point = MultiplicationGame();
                    break;
                case 3:
                    point = DivisionGame();
                    break;
            }
            return point;
        }

        internal void ShowHistory()
        {
            foreach (var line in history)
            {
                Console.WriteLine(line);
            }
        }


        internal void ChangeDifficulty()
        {
            Console.WriteLine("Coming Soon");
        }

        internal void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine(@"Select your game or Select an option
    1   Addition
    2   Subtraction
    3   Multiplication
    4   Division
    5   Random Game
    6   Show History
    7   Change Difficulty
    8   Exit");
        }

        internal void Play()
        {
            bool gameOver = false;
            int point = 0;

            while (!gameOver)
            {
                DisplayMenu();
                int selection = Helpers.getUserAnswer();
                switch (selection)
                {
                    case 1:
                        point += AdditionGame();
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 2:
                        point += SubtractionGame();
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        point += MultiplicationGame();
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 4:
                        point += DivisionGame();
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 5:
                        point += RandomGame();
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 6:
                        ShowHistory();
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 7:
                        ChangeDifficulty();
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine($"Your total score: {point}");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        gameOver = true;
                        break;
                }
            }
        }

        internal int ValidateAnswer(int answer, int result, int firstNumber, int secondNumber, char operation)
        {
            int point = 0;

            if (answer == result)
            {
                point = 5;
                Console.WriteLine("Correct! 5 Point");
                history.Add($"{DateTime.Now:MM/dd/yyyy HH:mm:ss} | {firstNumber} {operation} {secondNumber} | Your answer: {answer} | Correct answer: {result} | Point: {point}");
            }
            else
            {
                Console.WriteLine("WRONG! Try Again");
                history.Add($"{DateTime.Now:MM/dd/yyyy HH:mm:ss} | {firstNumber} {operation} {secondNumber} | Your answer: {answer} | Correct answer: {result} | Point: {point}");
            }
            return point;
        }
    }


}