namespace BarracksGame
{
    // 건물은 SCV라는 유닛이 건물을 지을수 있습니다.
    // Barracks 건물 클래스를 상속 받습니다.
    // barracks는 유닛을 생성하는 건물입니다.
    // 생성할 수 있는 유닛은 마린, 파이어벳, 메딕, 고스트가 있습니다.

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Build
    {
        public virtual void TrainUnit(Unit unit)
        {
            Console.WriteLine("유닛 생성");
        }
    }
    class Barracks : Build
    {
        public override void TrainUnit(Unit unit)
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.M:
                    if (unit is Marine)
                    {
                        Marine? marines = unit as Marine;
                        Console.WriteLine("마린 생성");
                    }
                    break;
                case ConsoleKey.F:
                    if (unit is Firebat)
                    {
                        Firebat? firebats = unit as Firebat;
                        Console.WriteLine("파이어벳 생성");
                    }
                    break;
                case ConsoleKey.G:
                    if (unit is Ghost)
                    {
                        Ghost? ghosts = unit as Ghost;
                        Console.WriteLine("고스트 생성");
                    }
                    break;
                case ConsoleKey.C:
                    if (unit is Medic)
                    {
                        Medic? medics = unit as Medic;
                        Console.WriteLine("메딕 생성");
                    }
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
    class CommandCenter : Build
    {
        public override void TrainUnit(Unit unit)
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.S:
                    if (unit is SCV)
                    {
                        SCV? scvs = unit as SCV;
                        Console.WriteLine("SCV 생성");
                    }
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
    class Unit
    {
        public virtual void Move()
        {
            Console.WriteLine("이동하였습니다.");
        }
    }
    class SCV : Unit
    {
        public void Building(Build building)
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.C:
                    if (building is CommandCenter)
                    {
                        CommandCenter? comcen = building as CommandCenter;
                        Console.WriteLine("CommandCenter 생성");
                    }
                    break;
                case ConsoleKey.B:
                    if (building is Barracks)
                    {
                        Barracks? baraks = building as Barracks;
                        Console.WriteLine("Barracks 생성");
                    }
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
    class Marine : Unit
    {
        public override void Move()
        {
            base.Move();
        }
    }
    class Firebat : Unit
    {
        public override void Move()
        {
            base.Move();
        }
    }
    class Ghost : Unit
    {
        public override void Move()
        {
            base.Move();
        }
    }
    class Medic : Unit
    {
        public override void Move()
        {
            base.Move();
        }
    }
}
