using System.Text;

namespace SwapGame
{
    // 구현 요소
    // 플레이어와 컴퓨터가 랜덤한 값을 가짐
    // 플레이어는 컴퓨터의 값을 알 수 없음
    // 플레이어에게는 컴퓨터와 자신의 값을 바꿀 기회를 제공
    // 운으로 플레이어가 바꿀지 말지 결정하여 승부가 나는 간단한 미니게임

    internal class Program
    {
        static void Main(string[] args)
        {
            SwapGame sg = new SwapGame();
            sg.GameStart();
        }
    }

    class SwapGame
    {
        private int playerValue;
        private int computerValue;
        private bool isGameOver = false;
        private bool isSwap = false;

        public int PlayerValue
        {
            set { playerValue = value; }
            get { return playerValue; }
        }
        public int ComputerValue
        {
            set { computerValue = value; }
            get { return computerValue; }
        }
        public bool IsGameOver
        {
            set { isGameOver = value; }
            get { return isGameOver; }
        }
        public bool IsSwap
        {
            set { isSwap = value; }
            get { return isSwap; }
        }

        public void GameStart()
        {
            StartLogo();
            RollDice();
            while (!IsGameOver)
                SelectValue();
            ShowResult();
        }
        private void StartLogo()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            string gameTitle = "=====Number Change Game=====";
            int frames = gameTitle.Length;

            for (int i = 0; i < frames; i++)
            {
                sb.Append("=");
            }

            string tempTitle = null;
            tempTitle = sb.ToString();

            for (int i = 0; i < frames; i++)
            {
                sb2.Append("=");

                Console.Clear();
                Console.WriteLine(gameTitle);
                tempTitle = tempTitle.Substring(1);
                Console.WriteLine(tempTitle);
                Console.WriteLine(sb2.ToString());
                Console.WriteLine("============================");

                Thread.Sleep(50);
            }
        }

        private void RollDice()
        {
            Random random = new Random();
            playerValue = random.Next(1, 6);
            computerValue = random.Next(1, 6);
        }

        private void Swap()
        {
            int temp = playerValue;
            playerValue = computerValue;
            computerValue = temp;
        }

        private void SelectValue()
        {
            Console.Clear();
            Console.WriteLine("==== 스왑 하시겠습니까? ====");
            Console.WriteLine("=  (1) Yes         (2) No  =");

            if(!IsSwap)
                Console.WriteLine("============================");
            else
                Console.WriteLine("===== 스왑 하였습니다. =====");
            
            Console.WriteLine("=  No를 선택시 게임결과로  =");


            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Swap();
                    IsSwap = true;
                    break;
                case ConsoleKey.D2:
                    isGameOver = true;
                    break;
            }
        }

        private void ShowResult()
        {
            Console.Clear();
            Console.WriteLine("========== Result ==========");
            Console.WriteLine($"       Player의 값 : {PlayerValue}");
            Console.WriteLine($"     Computer의 값 : {ComputerValue}");

            switch (HowResult())
            {
                case 0:
                    Console.WriteLine("   Draw!!! 무승부 입니다.");
                    break;
                case 1:
                    Console.WriteLine("  Victory!!! 승리했습니다.");
                    break;
                case 2:
                    Console.WriteLine("Lose..Computer가 승리했습니다.");
                    break;
            }
        }

        private int HowResult()
        {
            if (PlayerValue == ComputerValue)
                return 0;
            return PlayerValue > ComputerValue ? 1 : 2;
        }
    }
}
