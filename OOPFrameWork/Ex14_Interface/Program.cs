using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_Interface
{

    /*
    인터페이스 : 표준, 약속, 규칙, 규약을 만드는 행위
    ex) 갤럭시 쓰는 사람이 아이폰으로 전화하더라도 할 수 있고, 어느 아파트를 가던지 엘레베이터를 이용할 수 있다.
    1. 소프트웨어 설계의 최상위 단계
    2. 게임 >> run() 달린다 , move (int x, int y) 표준
     
    ** 초급 개발자 **
    1. 인터페이스를 [다형성] 입장에서 접근 사용(Interface를 부모타입으로 사용)
    2. 서로 연관성이 없는 클래스를 하나로 묶어줌. (notebook과 tv를 Product라는 부모로 엮어줌)
    3. C#이 제공하는 수 많은 API (Collection) >> Interface가 활용 >> 사용 방법에 초점 >> 다형성
    4. ~ 할 수 있는 (~able), I~ 수리할 수 있는, 날 수 있는, 같은 의미로 접근하면 된다.
    5. 객체 간 연결고리(객체 간 소통의 통로) >> 다형성

    문법)
    1. 인터페이스는 모든 멤버가 구현부를 가지지 않는다.
    2. 인터페이스는 상속을 통한 강제 구현을 목적으로 한다.
    3. 모든 접근자는 public ... 코드에서 굳이 사용 할 필요 없다.(그래서 생략함 어차피 public)
    4. 멤버 필드를 가지지 않음.
    5. 유일하게 다중상속을 지원 (여러 개의 약속을 모아서 강제 구현) >> 인터페이스는 작은 단위로 만든다.
    */

    interface Ia { // 관용적 표현 Irannable, Icloneable, ...
        // default로 public 이라 굳이 안 쓴다.
        void m(); // 자동으로 public , virtual
        int Count // 자동으로 public , virtual 강제로 property get 구현하도록
        {
            get;
        }
    }

    interface Ib 
    {
        void m2();    
    }

    abstract class Abclass 
    {
        public void run(){ } // 완성된 자원 +
        public abstract void move(); // 미완성 자원 
    }

    // java >> class Child extends Abclass implements Ia, Ib
    // C#   >> :
    class Child : Abclass, Ia, Ib
    {
        public override void move() // 추상 클래스 추상 함수 구현
        {
            Console.WriteLine("Abclass.move()");
        }

        public int Count
        { // Ia 추상 property Count  // override 없이 구현
            get { return 100; }
        }

        public void m() // override 없이 구현
        {
            Console.WriteLine("Ia.m()");
        }

        public void m2() // override 없이 구현
        {
            Console.WriteLine("Ib.m2()");
        }
    }

    #region
    // 인터페이스
    // 4. ~ 할 수 있는 (~able), I~ 수리할 수 있는, 날 수 있는, 같은 의미로 접근하면 된다.
    // 5. 객체 간 연결고리(객체 간 소통의 통로) >> 다형성

    interface Irepairable { } // 수리할 수 있는~ (하나의 의미로 묶어준다)

    class Unit
    {
        public int hitpoint; // 기본 에너지
        public readonly int MAXHP; // 최대 에너지 // 객체마다 초기화 할 거니까 readonly
        public Unit(int hp) 
        {
            this.MAXHP = hp;
        }
    }

    // 지상유닛
    class GroundUnit : Unit
    {
        public GroundUnit(int hp) : base(hp) // Unit이 가지고 있는 부모 생성자 호출
        {

        }
    }

    class AirUnit : Unit
    {
        public AirUnit(int hp) : base(hp) // Unit이 가지고 있는 부모 생성자 호출
        {

        }
    }

    class CommandCenter : Irepairable
    {
        // 수리하는 방법이 다르다
    }

    class Tank : GroundUnit , Irepairable
    {
        public Tank() : base(50)
        {

        }
        public override string ToString()
        {
            return "Tank";
        }
    }

    class Marine : GroundUnit
    {
        public Marine() : base(50)
        {

        }
        public override string ToString()
        {
            return "Marine";
        }
    }

    class SCV : GroundUnit , Irepairable
    {
        public SCV() : base(50)
        {

        }
        public override string ToString()
        {
            return "SCV";
        }

        // 수리하다
        // svc만의 구체화되고 특수화된 기능
        // repair
        // repair 대상은 Tank, SCV , CommandCenter
        // 
        /*        public void repair(Tank t)
                {
                    if (t.hitpoint != t.MAXHP)
                    {
                        t.hitpoint += 5;
                    }

                }
                public void repair(SCV s)
                {
                    if (s.hitpoint != s.MAXHP)
                    {
                        s.hitpoint += 5;
                    }
                }
                public void repair(CommandCenter c)
                {

                }*/

        /* 
         * 문제점)
        1. Unit 개수가 증가하면 repair 함수의 개수도 같이 증가한다
        2. 한 개의 repair 함수로 모든 수리를 하고 싶다
        ex) public void repair(Unit unit) { }  이렇게 하면?
        - marine은 repair 대상이 아니다.
        - scv(o), tank(o), commandCenter (x)
        ex) public repair(void GroundUnit unit) 이러면?
        // marine은 repair 대상이 아니다.

        marine / scv / tank / commandCenter -> 서로 연관성이 없다.
        - 서로 연관성이 없는 자원들을 묶어주기 -> [Interface] 사용하면 되지! >> L81
        - 수리 가능한, 수리할 수 있는 (~able) : Interface >> L81
        - class CommandCenter : Irepairable
        - class Tank : GroundUnit , Irepairable 
        - class SCV : GroundUnit , Irepairable
         */
        public void repair(Irepairable repairUnit) // Irepairable 부모타입 : CommandCenter, Tank, SCV
        {
            // 수리하는 방법 (HP)
            // CommandCenter, Tank, SCV
            // repairUnit이 무엇인지 판단해서 로직을 다르게 해야 한다.(CommandCenter는 수리 방법이 다름)

            // 아래의 코드를 해결하는 방법은? (hint = type 비교)

            /*            Unit unit = (Unit)repairUnit; // downcasting // 이 코드의 문제점 >> repairUnit에 CommandCenter 오면
                        if (unit.hitpoint != unit.MAXHP)
                        {
                            unit.hitpoint += 5;
                        }*/

            // 또는 if(repairunit.GetType() == typeof(Unit))
            if (repairUnit is Unit)
            {
                Unit unit = (Unit)repairUnit;  //downcasting
                if (unit.hitpoint != unit.MAXHP)
                {
                    unit.hitpoint += 5;
                }
            }
            // 또는 else if(repairunit.GetType() == typeof(CommandCenter))
            else if (repairUnit is CommandCenter)
            {
                CommandCenter cc = (CommandCenter)repairUnit;
                Console.WriteLine("I'm CommandCenter");
            }
        } // 1조꺼

    }
    #endregion




    class Program
    {
        static void Main(string[] args)
        {
/*            Child child = new Child();
            child.m();
            child.m2();
            child.move();
            Console.WriteLine(child.Count);*/


        }
    }
}
