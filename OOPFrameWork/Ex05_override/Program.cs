using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_override
{
    /*
      [상속관계]에서 override : 상속 관계에서 자식이 부모의 자원을 재정의 (자원 : member field , method)
      상속 관계에서 자바클래스가 부모클래스의 method(함수) 내용만 바꾼다
      재정의 : 틀의 변화는 없고 (내용만) {안쪽 ... 수정} 함수의 이름 타입을 바꾸는 것 아니다.

      1. 부모 함수 이름 동일
      2. 부모 함수 parameter 동일
      3. 부모 함수 return type 형식 동일
      4. 결국 { 실행블록 안의 코드만 변경 } 
        
      new(상위자원 무시하기) / virture(재정의 해 줬으면 좋겠어 : 강한 의지) / override(재정의)


    Tip) java는 
    @override
    public void 재정의() {}

     */

    // new
    public class BaseC
    {
        public int x = 100;
        public void Invoke() {
            Console.WriteLine("부모함수");
        }
    }
    public class DerivedC : BaseC
    {
        new public int x = 111;
        new public void Invoke() {
            Console.WriteLine("자식함수");
        }
    } // 같은 게 있으면 자식꺼로 보여주는데 그럴 때는 new 써라(new 안써도 똑같은데 써야 가시성 좋음)


    // virtual
    class Father
    {
        public int Fmoney = 1000;
        public void Fprint()
        {
            Console.WriteLine("Fmoney:{0}", Fmoney);
        }

        public virtual void Vprint() 
        {
            // 자식아 Vprint 재정의 했으면 좋겠어(안하면 말고)
            // 이름은 그대로 Vprint인데 다른 내용일거야 그러니 니가 바꿔
            Console.WriteLine("부모 함수 Vprint");
        }

    }

    class Child : Father {
        public override void Vprint()
        {
            //base.Vprint();
            Console.WriteLine("부모의 뜻을 받들어 재정의 합니다."); // 이러면 L58대신에 L67 출력됨, override 했으니까
        }
            // 상속 관계에서 재정의한 부모함수를 부르는 유일한 방법은
            // base 상속 관계에서 this
            // "base()"는 상속관계에서 "this()"와 똑같다
            // Tip) java는 super

        public void FatherMethod()
        {
            base.Vprint(); // 상위 자원으로 가서 함수 호출
        }
            
    }

    // 간단한 문제
    class Point2
    {
        public int x = 4;
        public int y = 5;

        public virtual string getPosition() // 한 점을 가지는 클래스 // 원래 수정 전 코드는 string getPosition(){}
        {
            return this.x + ":" + this.y;
        }
    }

    class Point3D : Point2 {
        int z = 6;


        // 상속관계에서 안 좋은 방법(새로운 함수 추가하는 거)
        /*        string getPosition3D()
                {
                    return this.x + ":" + this.y + this.z;

                }*/

        // 권장하는 방법 .. 추가적인 내용에 대한 출력이 있는 방법
        // L87 public virtual 추가
        public override string getPosition()
        {
            return this.x + ":" + this.y + this.z;
        }
    }

    // Point3D p = new Point3D();
    // p.getPosition();    >>  x,y



    class Program
    {
        static void Main(string[] args)
        {
            DerivedC derivedC = new DerivedC();
            derivedC.Invoke();
            Console.WriteLine(derivedC.x);

            Child child = new Child();
            child.Fprint();
            child.Vprint();

            // 문제점
            // 부모가 정의한 Vprint 함수는 영원히 못 보나?
            // 상속 관계에서는 부모가 heap에 먼저 올라가고 자식이 따라서 heap에 올라감
            // child 타입은 heap에 있는 Father, Child 객체에 대한 접근이 가능하다(상속관계니까)
            // 부모 쪽에 있는 함수를 자식이 재정의 했다면, child 입장에서는 부모 자원을 볼 수 없음
            // child는 재정의 한 자원만 접근 가능

            // @@@ 다형성 @@@
            // 부모타입은 자식타입의 주소를 가질 수 있다.

            Father f = child; // 자식이 가지고 있는 주소를 부모 타입의 f 라는 변수에 할당(단, 상속관계에서)
            // @@@ 부모 타입으로 접근하더라도 재정의가 되어 있다면 자식 쪽으로 넘겨버린다@@@
            f.Vprint(); // Father가 가지고 있는 함수가 아님 // L67 출력됨

            child.FatherMethod(); // 재정의가 되어 있을 때, 부모 함수를 부르는 유일한 방법 L76
        }
    }
}
