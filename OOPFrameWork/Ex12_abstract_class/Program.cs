using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_abstract_class
{

    /*
        1. 추상 클래스(미완성 클래스)
        2. 1의 미완성은 (완성 + 미완성) >> 함수를 구현 했느냐{}, 구현하지 않았느냐{}x 차이(중괄호 블록 = 실행블록을 가지고 있는지 차이)
        * 추상 클래스 사용하는 목적 : 상속 관계에서 Method의 [강제 구현]을 목적으로 설계하는 것 (이 함수는 반드시 재정의 해야 됩니다.)
        3. 특징) 1. 스스로 객체를 못 만든다.(완성된 게 없으니까)
                 2. 반드시 상속 관계에서만 구현한다.
                 3. abstract method를 반드시 구현해야 한다.
                 4. abstract method (자동 virtual) 반드시 override 구현(재정의)
                 5. abstract property {get; set;} 구현은 추상함수 동일

     */


    abstract class AbstractClass {
        public void print() {
            Console.WriteLine("완성된 코드");
        }

        public abstract void abMethod(); // {} 실행블록을 가지지 않는 함수 >> 상속관계에서 강제적 구현을 목적
    
    }

    class Dummy : AbstractClass { // 오류나는 게 강제적 구현하라는 뜻
        public override void abMethod() 
        { // 강제구현은 실행블록 만들기이다! >> 안에 내용은 쓰는 내 마음대로
            Console.WriteLine("추상 클래스 구현");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dummy dummy = new Dummy();
            dummy.abMethod(); // 상속 관계에서 재정의 한 것
            dummy.print(); // 원래 자기 꺼
        }
    }
}
