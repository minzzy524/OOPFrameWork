using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Inheritance_Composition
{
    /*
     * 개발환경에서 업무가 복잡하다.(도메인지식)
     * 쇼핑몰 
     * 회원관리, 주문관리, 상품관리, 배송관리, ....(각각의 업무가 서로 연관 되어있음 ㄷㄷ)
     * 여러개의 설계도는 관계를 가져야 한다
     * 1. 상속 (is ~a) 은 ~ 이다 명제가 성립되면 90% 상속을 통해 구현..(원은 도형이다, 강아지는 동물이다)
     * 2. 포함 (has ~ a) 은 ~을 가지고 있다 (자동차는 엔진을 가지고 있다, 경찰은 권총을 가지고 있다)
     * 
     * 원과 도형간의 관계
     * 원은 도형이다. 
     * 
     * 원 - 점과의 관계
     * 원은 점이다 - > x
     * 원은 점을 가지고 있다(0)
     * class 원 { 점이라고 하는 자원을 가지고 있다}
     * 
     * 경찰 -권총 (포함)
     * 경찰은 권총을 가지고 있다
     * class 경찰 { 권총 자원을 가지고 있다.}
     * 
     * ex)원, 삼각형, 사각형 설계도 제작
     * 
     * 원은 도형이다
     * 삼각형은 도형이다
     * 사각형은 도형이다.
     * 
     * 도형 : 추상화, 일반화  :draw 그리기 , 색상 >> 공통자원
     * (원, 삼각형, 사각형의 공통분모 )
     * 원 : 구체화, 특수화 (반지름, 한점)>> 본인만 갖고 있는 특징 >> 부품속성 (한점은 x축과 y축)
     * 
     * class shape {색상 , 그리다} >> 부모 역할
     * class point {좌표값} >> 부품 >> 포함관계로 사용
     * 
     * class circle : shape { Point 
     *}
     */
    class Shape
    {
        //공통 속성, 공통 함수
        public string color = "gold";
        public void draw()
        {
            Console.WriteLine("도형을 그리다");
        }
    }
    class Point
    {
        int x;
        int y;

        public Point() //기본점 //안좋아 보여요 (할당 2번) 추후에 this() 생성자 호출 할당 1개로 줄인다.
        {
            x = 1;
            y = 1;
        }
        public Point(int x, int y) //원하는 점
        {
            this.x = x;
            this.y = y;
        }
    }
    //문제 
    //원을 만드세요 (원의 정의 : 원은 한점과 반지름을 가지고 있다)
    //1. 원은 도형이다
    //2. 원은 점을 가지고 있다.
    //3. 원은 반지름을 가지고 있다.(특수성)
    //3.1 원의 반지름은 초기값 10을 가지고 있다.
    //3.2 점의 좌표는 초기값 10, 15
    // 기본 초기값을 설정하지 않으면 반지름과 점의 값을 입력받을 수 있다(원이 만들어 질 때)
    class circle : Shape //상속
    {
        public int x; //원래는 아닌데 출력해보려고 잠시만 해놓음 원래는 private 
        public int y;

        //문제점 : 각각의 생성자에 memberfield에 할당 작업을 반복적으로 하고 있다....고민...해보기...;;
        //답안 : this 

        Point point; //포함 (다른 클래스 타입을 member field로 가지는 것) ******
        int r;

        public circle()
        {
            this.r = 10;
            this.point = new Point(10, 15);
        }
        public circle(int r, Point point)
        {
            this.r = r;
            this.point = point;
        }
        public void circlePrint()
        {
            Console.WriteLine("반지름 :{0}, 좌표값 :{1}", r, point);
        }

/*        public override void draw() {
            // base.draw();
            Console.WriteLine("원을 그리다");
        }*/

    }

    //문제2) 
    //삼각형 클래스를 만드세요
    // 삼각형의 정의는 3개의 점과 색상과 그리다 라는 기능을 가지고 있다.
    //shape , point 클래스는 제공을 받는다.
    //default 값으로 삼각형을 그릴 수 있고 
    //3개의 좌표값을 모두를 입력받아서 삼각형을 그릴 수 있다.


    /* 60점
    class triangle : Shape
    {
        Point point; //한 점
        Point point2;
        Point point3;
       public triangle()
        {
            point = new Point(1, 2);
            point2 = new Point(3,4);
            point3 = new Point(5,6);
        }
        public triangle(Point x, Point y, Point z)
        {
            this.point = point;
            this.point2 = point2;
            this.point3 = point3;
        }
    }*/
    class triangle : Shape
    {
        Point[] pointarray;
        public triangle()
        {
            pointarray = new Point[3] { new Point(1, 2), new Point(3, 4), new Point(5, 6) };

        }
        public triangle(Point[] pointarray)
        {
            this.pointarray = pointarray;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            c.draw();

            //반지름과 좌표값을..
            circle c2 = new circle();
            c2.draw();
            c2.circlePrint();



            circle c3 = new circle(5, new Point(6, 9));
            c3.draw();
            c3.circlePrint();

            Point[] pointarray = new Point[] { new Point(10, 20), new Point(30, 40), new Point(50, 60) };
            triangle t2 = new triangle(pointarray); //방법1


            triangle t3 = new triangle(new Point[] { new Point(10, 20), new Point(30, 40), new Point(50, 60) }); //방법2
            //두개 다 같은 방법이지만 방법 1은 pointarray가 다른곳에서 사용할거면 쓰는거고 방법2는 여기에서만 사용한다면 사용될 ~
        }
    }
}

/*
 상속의 진정한 의미 : 재사용성 (부모) 
상속은 좋은걸까? : 초기 설계 비용이 많이 듬, 상속 (부모와 자식 관계) >> 현대에서는 주로 interface를 활용한 decoupling한 프로그램을 추구
 */