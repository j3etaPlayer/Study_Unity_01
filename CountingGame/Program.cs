namespace CountingGame
{
    static class GameSetting
    {
        // 게임 기본설정
        public static string signWall = "■";
        public static string signBlank = "　";
        public static string signCheck = "√";
        public static int backWidth = 30;
        public static int backHeight = 10;
        public static int titlePosWidth = 3;
        public static int titlePosHeight = 2;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                BackGround();
                GameUpdate();
                Thread.Sleep(3);
                Console.Clear();
            }
        }

        static void GameUpdate()
        {
            Console.SetCursorPosition(GameSetting.titlePosWidth, GameSetting.titlePosHeight);
            Console.WriteLine("■　　■　■　■　■　　　■　　■■■　■　■　■　■");
            Console.SetCursorPosition(GameSetting.titlePosWidth, GameSetting.titlePosHeight+1);
            Console.WriteLine("■■　■　■　■　■■　■■　　■　　　■　■　■　■");
            Console.SetCursorPosition(GameSetting.titlePosWidth, GameSetting.titlePosHeight+2);
            Console.WriteLine("■　■■　■　■　■　■　■　　■　　　■■■　■■　");
            Console.SetCursorPosition(GameSetting.titlePosWidth, GameSetting.titlePosHeight+3);
            Console.WriteLine("■　　■　■■■　■　■　■　　■■■　■　■　■　■");
        }

        static void BackGround()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < GameSetting.backHeight + 2; y++)
            {
                for (int x = 0; x < GameSetting.backWidth + 2; x++)
                {
                    if (x == 0 || x == GameSetting.backWidth +1)
                        Console.Write(GameSetting.signWall);
                    else if (y == 0 || y == GameSetting.backHeight +1)
                        Console.Write(GameSetting.signWall);
                    else
                        Console.Write(GameSetting.signBlank);
                }
                Console.WriteLine();
            }
        }

        static void GamePlay()
        {
            Console.Write("최초 숫자를 입력해주세요 : ");
            int num = int.Parse(Console.ReadLine()); ;
            int GameCounter = 20;

            for (int i = 1; i < GameCounter; i++)
            {
                Console.Write("입력 : ");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput > num || num > userInput)
                {
                    if (num > userInput)
                        Console.WriteLine($"입력한 값({userInput})이 정답보다 낮습니다.");
                    else
                        Console.WriteLine($"입력한 값({userInput})이 정답보다 높습니다.");

                    Console.WriteLine($"{GameCounter - i}회 남았습니다.");
                }
                else
                {
                    Console.WriteLine($"정답({userInput})!!!");
                    Console.WriteLine($"{i}번 만에 정답을 맞추었습니다.");
                    break;
                }
            }
        }

    }
}
