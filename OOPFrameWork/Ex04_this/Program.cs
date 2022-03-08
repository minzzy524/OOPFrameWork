using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_this
{
    // this : 객체 자신을 가르키는 this (앞으로 생성될 객체의 주소를 가진다는 가정하에)
    // 사용 : member field 와 parameter 구분
    // 관용적으로 함수 parameter 의 이름과 member field 이름과 동일하게(개발자의 가독성을 높이기 위해)
    
    // this : 생성자를 호출하는 this

    class ThisSelf {

        private string name;
        private int age;

        /*
        할당이라는 측면에서 보면 
        public ThisSelf() {
            this.name = "홍길동";     -> 1개
            this.age = 0; // 기본값 할당
        
        }

        public ThisSelf(string name) { // name 사용하면 ... member field name에 할당 될거야
            this.name = name;         -> 2개
            this.age = 0; // 기본값 할당
        }

        public ThisSelf(string name, int age) {    -> 3개
            this.name = name;  // this.name에서 name은 L16 name , = name; 에서 name은 parameter를 지칭하는 L21 name
            this.age = age;

        }
        */

        public ThisSelf() : this("홍길동")
        {
            Console.WriteLine("매개변수가 없어요");

        }

        public ThisSelf(string name) : this(name, 0)
        { // name 사용하면 ... member field name에 할당 될거야
            Console.WriteLine("매개변수가 하나 있어요");
        }

        public ThisSelf(string name, int age)
        {   
            // member field에 대한 할당을 한번만(반복적인 코드를 줄인 것)
            this.name = name;  // this.name에서 name은 L16 name , = name; 에서 name은 parameter를 지칭하는 L21 name
            this.age = age;
            Console.WriteLine(" 매개 변수가 2개 : {0} - {1}", this.name , this.age);

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            // ThisSelf thisSelf = new ThisSelf(); // 멤버필드에 이름과 나이가 있겠구나 유추
            // 원칙적으로 생성자 함수는 객체 생성시 1개만 호출
            // 예외적으로 this를 구현 한다면 여러개의 생성자를 호출할 수 있다

            // ThisSelf thisSelf = new ThisSelf("김유신");
            ThisSelf thisSelf = new ThisSelf("김유신",100);
        }
    }
}


