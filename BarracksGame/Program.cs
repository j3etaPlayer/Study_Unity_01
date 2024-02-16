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
            Console.WriteLine("Hello, World!");
        }
    }


    class Building
    {

    }
    class Barracks : Building
    {
        public void TrainUnit()  // 형변환과 조건을 사용해서 유닛을 생성시킨다.
        {
            // M 입력시 marine 생성
            // F 입력시 Firebat 생성
            // G 입력시 Ghost 생성
            // C 입력시 Medic 생성
        }
    }
    class CommandCenter : Building
    {
        // 스킬 : 유닛생성(SCV)
    }
    class Unit
    {
        public virtual void DoAttack()
        {
            Console.WriteLine("공격합니다.");
        }
        public virtual void UseSkill()
        {
            Console.WriteLine("스킬을 사용합니다.");
        }
    }
    class SCV : Unit
    {
        public override void UseSkill()
        {

        }
        private void MakeBuilding()
        {

        }
    }
    class Marine : Unit
    {
        public override void DoAttack()
        {

        }
        public override void UseSkill()
        {

        }
    }
    class Firebat : Unit
    {
        // 공격 : 화염방사기
    }
    class Ghost : Unit
    {
        // 공격 : 저격총
        // 스킬 : 클록킹
    }
    class Medic : Unit
    {
        // 스킬 : 치료
    }
}
