using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_User_Provider
{
    /*
    객체간의 관계
    상속 : 포함

    포함 이야기

    user : 사용자 (어떤 클래스 ...)
    provider : 제공자(어떤 클래스...)

    class A{}
    class B{}
    관계 : A는 B를 사용합니다.

    1. 상속 : class A : B {}
    2. 포함 : A라는 클래스 안에서 member field로 B를 사용 >> class A { B b; }
    2.1 포함인데 [부분]과 [전체]로 나누어 짐(생성과 소멸 같이 할거냐 안 할거냐)
    
    class B{}

    class A{
        B b; // 포함 (A는 B를 사용합니다.)
        A(){
            b = new B ();
        }
    }
    >> B는 독자적으로 생성된 게 아니고, A라는 객체가 생성될 때 같이 생성된다. // 자동차가 만들어지면 엔진도 만들어진다.
    >> ex) A a = new A(); >> A와 B는 라이프 사이클이 똑같다. 
    >> 운명공동체 (전체, composition)

    ------------------------------------------------------------------------

    class B{}

    class A{
        B b; // 포함 (A는 B를 사용합니다.)
        A(){
            A( B b ) {
                this.b = b; // 이러면 운명공동체 x
           };
        }

        void method(B b){
            this.b = b;  // 이렇게도 된다.
        }
    }
    >> Main() { B b = new b();  A a = new A(b);   } 
    >> 서로 다른 운명 // 경찰은 밖에 나갈 때 총을 챙긴다. (필요에 따라서)
    >> (부분) (A와 B는 Life cycle이 다르다) >> B는 밖에서 만들어서 들어옴. A와는 관계 없음


    ------------------------------------------------------------------------

    @@@ 의존관계(dependency) : [함수]를 기반으로 ("함수 안에서" 생성, 전달 ...)

    class B {}
    class A{
        // member field로 B타입 변수를 가지지 않는 것
        
        // 함수를 기반으로 해서 
            B print(){
                B b = new B(); // 이게 의존관계 (함수 안에서 생성, 전달)
                return b;
            }
        }

    @@@ 활용 사례 @@@
    interface Icall{ void m(); }

    class C : Icall{
        // 반드시 재정의 필요
        public void m(){}
    }
    clss D : Icall{
        // 반드시 재정의 필요
        public void m(){}
    }

    @@@ 현대적인 프로그램 방식에서는 유연하게, 대충 하는 것을 좋아함 (이가 없으면 잇몸으로)
    // 대충 짜보자

    class E {
        void method(Icall ic){ // 좋은 코드 (Icall interface를 구현한 C 또는 D가 올 수 있다)
                               // 확장 측면에서 좋다
        }
        
        void method2(C c){ // C라는 객체의 주소만

        }

        void method3(D d){ // D라는 객체의 주소만

        }
    }


     */



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
// 0311 18:30
