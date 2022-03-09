using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_OOP
{
    /* 객체지향
     * class == 설계도 == 데이터타입
     *
     *문제점) 설계도 1장이 아니라 여러장이 사용...
     *
     *초가집.. 99칸 기와집을 짓고싶다... -> 설계도 1장 이상 많이 필요함
     *설계도를 나누는 기준
     * 관계
     * 여러장의 설계도
     * is ~ a 무엇은 무엇이다 : 상속
     * has ~ a 무엇은 무엇을 가지고있다. : 포함
     * 
     * 상속... 여러개의 설계도가 있을때 부모설계도를 만드는것
     * 부모 - 자식 간의 관계
     * 1. 단일상속 (계층적 상속)
     * 2. 사용자가 만드는 모든 클래스는 기본적으로 object (root)를 상속하고 있다.
     * (다중상속하려면 계층적상속을 해야한다)
     */

    class GrandFather : Object //구현하지 않아도 default 상속 (단 접근자는 public)
    {
        public int Gmoney = 1000;
        private int Pmoney = 100000; //누구에게도 상속하지 않을거야
        protected int Tmoney = 2000; //protectec 상속관계에서만 존재 
        // 양면성 :상속관계 > public , 객체관계(참조변수)> private  -> ex)Child child = new Child();

    }
    class Father : GrandFather //java >> Father extends GrandFather
    {
        public int Fmoney = 500;
        public void print()
        {
            //Tmoney 가 상속 관계 내에서는 사용 가능 // L96에서 child.Tmoney(참조관계)에서는 불가능 
            Console.WriteLine("tmoney :{0}", Tmoney);
        }
    }
    class Child : Father
    {
        public int Cmoney = 100;
        //할아버지돈도 내돈, 아버지 돈도 내돈, 내 돈도 내돈..
    }
    sealed class aaa // 봉인 되었다. 상속할 수 없는 클래스이다. 
    {

    }
    // 상속 쌉 불가능 class bbb : aaa {} //상속 쌉 불가능


    // 다형성 : overloading  (이거만 외워 "하나의 이름으로 여러가지 기능을 갖는 것") **암기 >> 함수 (생성자 함수, 일반함수)
    // 함수 parameter [개수]와 [타입]을 다르게 하여 만드는 방법
    // 목적 : 개발자의 편의성
    // 오버로딩은 상속과 관계없음 (오버라이딩은 상속이 필요해 재정의니까)
    // 성능향상에 도움이 되지 않는다.
    class Test
    {
        public void method()
        {
            Console.WriteLine("일반함수");
        }
        //오버로딩 : 함수의 이름은 같지만 파라미터의 개수와 타입을 다르게했다. 
        public void method(int i)
        {
            Console.WriteLine("i;{0}", i);
        }
        public void method(string i)
        {
            Console.WriteLine("i;{0}", i);
        }
        public void method(int i, int j)
        {
            Console.WriteLine("i+j;{0}", i + j);
            //순서가 다름을 인정 overloading으로
        }
        public void method(string s, int i)
        {
        }
        public void method(int i, string s)
        {
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine("Gmoney : {0}", child.Gmoney);
            Console.WriteLine("Fmoney :{0}", child.Fmoney);
            Console.WriteLine("Cmoney:{0}", child.Cmoney);
            //child에서 protectec int tmoney에 대해선 접근이 불가능하다.

            Test t = new Test();
            t.method("a");
            t.method();



        }
    }
}