using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_abstract_class
{
    abstract class EmptyCan {
        public int count;
        public abstract int Count { // 강제 구현해라(property) 
            get; // retrun 하면 구현 한 것
            set; // value parameter 쓰면 구현한 것
        }

        public void speak() {
            Console.WriteLine("speak!");
        }

        public abstract void sound(); // sound를 강제 구현해라
        public abstract void who(); // who를 강제 구현해라

    }

    class BearCan : EmptyCan { 
    
        public override int Count // 추상 property 구현
        {
            get { return count; }
            set { this.count = value; }

        }

        public override void sound() 
        { // 강제 구현
            Console.WriteLine("깡깡깡");
        }

        public override void who()
        { // 강제 구현
            Console.WriteLine("홍길동");
        }
    }


    class cyderCan : EmptyCan
    {

        public override int Count // 추상 property 구현
        {
            get { return count; }
            set { this.count = value; }

        }

        public override void sound()
        { // 강제 구현
            Console.WriteLine("팅팅팅");
        }

        public override void who()
        { // 강제 구현
            Console.WriteLine("김민성");
        }

        // 필요하다면 함수 더 구현 (개발자 마음)

        public void where() 
        {
            Console.WriteLine("공원에서");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            BearCan bearCan = new BearCan(); // 
            bearCan.speak();
            bearCan.sound();
            bearCan.who();

            Console.WriteLine("----------------");

            cyderCan can = new cyderCan();
            can.speak();
            can.sound();
            can.who();
            can.where();
        }
    }
}
