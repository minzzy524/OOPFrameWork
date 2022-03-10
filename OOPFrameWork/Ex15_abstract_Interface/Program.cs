using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_abstract_Interface
{
    /*
        <추상클래스와 인터페이스의 공통점>
        1. 강제적 구현
        2. 상속을 목적으로 한다
        3. 스스로 객체 생성 불가
        4. 다형성 >> 캐스팅이 가능하다
        
        < 차이점>
        @ 추상클래스 만의 특징
        - 멤버필드를 가질 수 있다
        - 일반 함수를 가질 수 있다
        - 단일상속

        @ 인터페이스 만의 특징
        - 멤버필드를 가질 수 없다
        - 다중상속 (제일 큰 차이점)
        - 구현 코드를 갖지 않는다
     
     */

    /*
     게임(unit)

    unit 공통기능 ( 이동좌표, 이동 , 멈춘다 ) : 추상화 , 일반화
    unit 마다 이동 방법은 다르다. >> 강제로 유닛마다 별도로 구현
     
     */
    
    abstract class Unit
    {
        public int x, y;
        public void stop()
        {
            Console.WriteLine("Unit Stop");
        }

        // 이동
        public abstract void move(int x, int y); // move는 x,y 형식 맞춰서 니가 구현해봐

    }

    class Tank : Unit
    {
        public override void move(int x, int y) 
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Tank 이동 : " + this.x + " , " + this.y);
        }

        // Tank 특수화, 구체화
        public void chaneMode()
        {
            Console.WriteLine("Tank 변환 모드");
        }
    }

    class Marine : Unit
    {
        public override void move(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Marine 이동 : " + this.x + " , " + this.y);
        }

        // Tank 특수화, 구체화
        public void stimpack()
        {
            Console.WriteLine("스팀팩");
        }
    }

    class Dropship : Unit
    {
        public override void move(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("dropship 이동 : " + this.x + " , " + this.y);
        }

        // Tank 특수화, 구체화
        public void load()
        {
            Console.WriteLine("Unit Load");
        }

        public void unload()
        {
            Console.WriteLine("Unit UnLoad");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            tank.move(1, 2);
            tank.stop();
            tank.chaneMode();
            Console.WriteLine("-----------");

            Marine marine = new Marine();
            marine.move(3, 4);
            marine.stimpack();
            Console.WriteLine("-----------");

            Dropship dropship = new Dropship();
            dropship.move(5, 6);
            dropship.load();
            dropship.unload();

            Console.WriteLine("-----------");

            // 문제 1) 탱크 3대를 만들고 [같은 좌표]로 이동 시키세요

            // 원했던 답은 객체 배열
            Tank[] tanklist = { new Tank(), new Tank(), new Tank() };
            foreach (Tank t in tanklist)
            {
                t.move(100, 200);
            }

            Console.WriteLine("----------------");

            // 문제 2) 여러 개의 Unit(탱크1, 마린1, 드랍쉽1)를 만들고 같은 좌표로 이동 시키세요
            // 다형성 (전자 제품 매장에서 buy(Product p) 했던 것 사용)
            Unit[] unitlist = { new Tank(), new Marine(), new Dropship() };
            foreach (Unit u in unitlist)
            {
                u.move(300, 400);
            }

        }
    }
}
