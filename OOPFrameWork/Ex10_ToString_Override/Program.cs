using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_ToString_Override
{

    // 1. 사용자가 만드는 모든 class는 기본적으로 Object를 상속 받는다.
    // 2. .NET Framework가 제공하는 수 많은 class도 Object를 상속받고, 필요에 따라 재정의를 구현하고 있다.

    class Person : Object {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return "Person : " + Name + "-" + Age;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person() { Name = "Smith" , Age = 12};
            //Console.WriteLine(person.ToString()); // Ex10_ToString_Override.Person >> Object의 Tostring() 그대로
            //Console.WriteLine(person); // Ex10_ToString_Override.Person 
            // 즉, ToString 안써도 기본값이다.

            Console.WriteLine(person.ToString()); // Person : Smith-12 -> L17 재정의 결과 // 개발자가 목적에 딸른 출력(재정의)
            Console.WriteLine(person); // Person : Smith-12 // 재정의하면 네임스페이스랑 클래스가 아니라 내가 재정의한 게 나온다
        }
    }
}
