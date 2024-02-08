namespace CountingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("최초 숫자를 입력해주세요 : ");
            int num = int.Parse(Console.ReadLine()); ;
            int GameCounter = 20;
            
            for (int i = 0; i < GameCounter; i++)
            {
                int userInput = int.Parse(Console.ReadLine());
                if(num > userInput)
                {

                }
                if (num < userInput)
                {

                }
                if (num == userInput)
                {

                }
                Console.WriteLine($"{GameCounter - i}회 남았습니다.");
            }
        }
    }
}
