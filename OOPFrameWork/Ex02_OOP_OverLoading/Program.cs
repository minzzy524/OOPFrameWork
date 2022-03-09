using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_OOP_Overloading
{
    //함수 : 생성자 함수, 일반 함수
    //생성자 : 오버로딩이 가능하다.
    //생성자 오버로딩 -> 멤버필드의 초기화를 위해서 한다.

    class Test
    {
        private string name;
        private int age;
        public Test()
        { //default constructor 기본생성자
          //멤버필드에 아무것도 안 정해놨을 때 기본 값 써 넣을 수 도 있다.
        } 
        public Test(string name)
        {  //오버로딩 생성자
        }
        public Test(string name, int age)
        {
            // 오버로딩 생성자가 많으면 옵션이 많다
            // 자동 차영업소에 방문함 
            // 예) 기본형, 옵션1/ 옵션 2 /옵션 3.. 변수의 초기화를 통해서 설정함
            // 왜 오버로딩 생성자를 만들어? 생성자를 여러 개 구현하려고
            // @@@ 메소드 오버로딩 하세요 -> "하나의 이름으로 작업을 해야 하구나"
            // @@@ 생성자 오버로딩 하세요 -> "초기화 하는 것을 많이 만들어야 하구나"
        }

        // 편하게 // 아니면 개발자가 종류별로 함수를 암기 해야 됨
        public void Print()
        {
            //method overloading (목적 : 편하게 쓰려고)
        }
        public void Print(int i)
        {

        }
        public void Print(string str)
        {

        }

        //의미 : 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Test test2 = new Test("기본값");
            Test test3 = new Test("기본값", 100);

            test.Print(100);
            test.Print(100);
        }
    }
}
