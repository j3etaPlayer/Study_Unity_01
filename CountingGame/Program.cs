using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;

namespace CountingGame
{
    static class GameSetting
    {
        // 게임 기본설정
        public static char signWall = '*';
        public static char signBlank = ' ';
        public static int backWidth = 40;
        public static int backHeight = 5;
        public static int maxGameCounter = 20;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MenuMain();
            }
        }
        static void BackGround()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < GameSetting.backHeight + 2; y++)
            {
                for (int x = 0; x < GameSetting.backWidth + 2; x++)
                {
                    if (x == 0 || x == GameSetting.backWidth + 1)
                        Console.Write(GameSetting.signWall);
                    else if (y == 0 || y == GameSetting.backHeight + 1)
                        Console.Write(GameSetting.signWall);
                    else
                        Console.Write(GameSetting.signBlank);
                }
                Console.WriteLine();
            }
        }

        static void GameReady()
        {
            bool isStart = true;
            bool isWarning = false;
            int number = -1;
            while (isStart)
            {
                Console.Clear();
                BackGround();

                if (isWarning)
                    CursorWrite(3, 5, "1에서 100 사이의 숫자를 입력해주세요");

                CursorWrite(10, 2, "최초 숫자를 입력해주세요");
                CursorWrite(14, 4, "입력(1~100) : ");

                number = int.Parse(Console.ReadLine());

                if (1 <= number && number <= 100)
                {
                    isStart = false;
                    GamePlay(number);
                }
                else
                    isWarning = true;
            }
        }
        static void GamePlay(int number)
        {
            int gameCounter = GameSetting.maxGameCounter;
            int uNumber = number;
            int userInput = -1;

            Console.Clear();
            BackGround();

            for (int i = 1; i < gameCounter; i++)
            {
                ClearInput(2, 2, 30);
                CursorWrite(14, 2, "입력 : ");

                StringBuilder userInputBuilder = new StringBuilder();

                ConsoleKeyInfo keyInfo;
                do
                {
                    keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.Backspace && userInputBuilder.Length > 0)
                    {
                        userInputBuilder.Length -= 1;
                        Console.Write("\b \b");
                    }
                    else if (keyInfo.Key == ConsoleKey.Enter|| keyInfo.Key == ConsoleKey.Spacebar)
                    {
                        break;
                    }
                    else if (char.IsDigit(keyInfo.KeyChar))
                    {
                        userInputBuilder.Append(keyInfo.KeyChar);
                        Console.Write(keyInfo.KeyChar);
                    }
                } while (keyInfo.Key != ConsoleKey.Enter);


                if (int.TryParse(userInputBuilder.ToString(), out userInput) && 1 <= userInput && userInput <= 100)
                {
                    if (userInput > uNumber)
                    {
                        CursorWrite(5, 3, $"입력한 값({userInput})이 정답보다 높습니다.");
                        CursorWrite(13, 4, $"{gameCounter - i}회 남았습니다.");
                    }
                    else if (uNumber > userInput)
                    {
                        CursorWrite(5, 3, $"입력한 값({userInput})이 정답보다 낮습니다.");
                        CursorWrite(13, 4, $"{gameCounter - i}회 남았습니다.");
                    }
                    else
                    {
                        RetryMenu(userInput, i);
                    }
                }
                else
                {
                    ClearInput(2, 2, 20);
                    CursorWrite(13, 3, $"입력한 값({userInput})은");
                    CursorWrite(9, 4, "잘못된 입력입니다.(1~100)");
                }
            }
        }

        static void MenuMain()
        {
            string title = "숫자 맞추기 게임";
            string[] selectTitle = { "Start", "Exit" };
            SelectMenu(title, selectTitle, -1, -1);
        }
        static void RetryMenu(int input, int counter)
        {
            string title = "게임을 다시 시작하시겠습니까?";
            string[] selectTitle = { "Yes", "No" };
            SelectMenu(title, selectTitle, input, counter);
        }
        static void SelectMenu(string title, string[] selectTitle, int input, int counter)
        {
            int select = 0;
            int maxSelect = 1;
            int choice = -1;

            while (choice <= 0)
            {
                Console.CursorVisible = false;
                Console.Clear();
                BackGround();
                if (input != -1 && counter != -1)
                    CursorWrite(7, 1, $"{counter}번 만에 정답을 맞추었습니다.");

                Selector(title, selectTitle, select);

                ConsoleKey key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.UpArrow:
                        select = (select > 0) ? 0 : maxSelect;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.DownArrow:
                        select = (select < maxSelect) ? maxSelect : 0;
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.Spacebar:
                        choice = select;
                        if (choice == 0)
                            GameReady();
                        else if (choice == 1)
                            Environment.Exit(0);
                        break;
                }
            }
        }

        static void Selector(string title, string[] titleSelect, int select)
        {
            Console.CursorVisible = false;

            CursorWrite(GameSetting.backWidth / 2 - title.Length + 3, GameSetting.backHeight / 2, title);
            Console.SetCursorPosition(12, 4);
            Console.Write("{0}{1}{2}", select == 0 ? ">" : " ", titleSelect[0], select == 0 ? "<" : " ");
            Console.SetCursorPosition(25, 4);
            Console.Write("{0}{1}{2}", select == 1 ? ">" : " ", titleSelect[1], select == 1 ? "<" : " ");
        }
        static void ClearInput(int left, int top, int width)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(new string(' ', width));
        }
        static void CursorWrite(int left, int top, string str)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(str);
        }
    }
}
