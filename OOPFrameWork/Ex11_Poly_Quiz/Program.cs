using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_Poly_Quiz
{

    /*
    문제)

    시나리오(요구사항)

    저희는 가전제품 매장 솔루션을 개발하는 사업팀입니다

    A라는 전자제품 매장이 오픈되면 

    [클라이언트 요구사항]

    가전제품은 제품의 가격 , 제품의 포인트 정보를 공통적으로 가지고 있습니다

    각각의 가전제품은 제품별 고유한 이름을 가지고 있다

    ex)

    각각의 전자제품은 이름을 가지고 있다(ex: Tv , Audio , Computer)

    각각의 전자제품은 다른 가격을 가지고 있다(Tv:5000, Audio:6000 ....)

    제품의 포인트는 가격의 10% 적용한다
    

    시뮬레이션 시나리오

    구매자 : 제품을 구매하기 위한 금액정보 , 포인트 정보를 가지고 있다 

    예를 들면 : 10만원 , 포인트 0

    구매자는 제품을 구매할 수 있다 , 구매행위를 하게되면 가지고 있는 돈은 감소하고 포인트는 올라간다

    구매자는 처음 초기 금액을 가질 수 있다

    */

    class Product : Object
    {
        public int price;
        public int bonuspoint;
        public Product() { }
        public Product(int price)
        {
            this.price = price;
            this.bonuspoint = (int)(this.price / 10.0);
        }
    }

    class KtTv : Product
    {
        public KtTv() : base(500) // 상위 생성자를 호출하는 base
        {

        }

        public override string ToString() // Object가 가지는 public virtual 자원 // Tostring 하면 제품 이름 나오게
        {
            return "KtTv";
        }

    }


    class Audio : Product
    {
        public Audio() : base(100)
        {

        }

        public override string ToString()
        {
            return "Audio";
        }
    }


    class NoteBook : Product
    {
        public NoteBook() : base(150)
        {

        }

        public override string ToString()
        {
            return "NoteBook";
        }
    }


    // 모든 전자제품의 부모는 Product(다형성)
    // Product product = new Audio();
    // Product product = new TV();
    // Product product = new NoteBook();
    // 단, Product는 자신의 자원만 볼 수 있다. 자식은 자식꺼 + 부모꺼 다 볼 수 있지



    //구매자
    class Buyer
    {
        private int money = 1000;
        private int bonuspoint;

        //구매자 구매행위 (기능)
        //구매행위 (잔액 - 제품의 가격 , 포인트 정보 갱신)
        //*************구매자는 매장에 있는 모든 물건을 구매할 수 있다 ***************
        //각각의 제품을 구매할 수 있는 함수 제공

        public void Buy(Product p) // TV 객체의 주소를 받음(주소를 받아야 가격을 알 수 있지)
        {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
            if (this.money < p.price)
            {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
                return; //함수 종료  (구매행위 함수 KttvBuy()의 종료)
            }
            //실 구매 행위
            this.money -= p.price; //잔액 // price랑 bonuspoint는 부모의 자원이라 쓸 수 있다.
            this.bonuspoint += p.bonuspoint; //누적
            Console.WriteLine("구매한 물건은 :" + p.ToString()); // 구매한 제품 이름 보여주기
        }

/*
        public void KttvBuy(KtTv n) // TV 객체의 주소를 받음(주소를 받아야 가격을 알 수 있지)
        {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
            if (this.money < n.price)
            {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
                return; //함수 종료  (구매행위 함수 KttvBuy()의 종료)
            }
            //실 구매 행위
            this.money -= n.price; //잔액
            this.bonuspoint += n.bonuspoint; //누적
            Console.WriteLine("구매한 물건은 :" + n.ToString()); // 구매한 제품 이름 보여주기
        }

        public void AudioBuy(Audio n)
        {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
            if (this.money < n.price)
            {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
                return; //함수 종료  (구매행위 종료)
            }
            //실 구매 행위
            this.money -= n.price; //잔액
            this.bonuspoint += n.bonuspoint; //누적
            Console.WriteLine("구매한 물건은 :" + n.ToString());
        }

        public void NoteBookBuy(NoteBook n)
        {  //함수가 제품 객체의 주소를  parameter  받아서 가격 ,포인트
            if (this.money < n.price)
            {
                Console.WriteLine("고객님 잔액이 부족합니다 ^^! " + this.money);
                return; //함수 종료  (구매행위 종료)
            }
            //실 구매 행위
            this.money -= n.price; //잔액
            this.bonuspoint += n.bonuspoint; //누적
            Console.WriteLine("구매한 물건은 :" + n.ToString());
        }*/


    }

    // 팀장이 휴가줘서 하와이 가서 놀다옴
    // 물건을 1000개를 추가했음 -> POS 시스템으로 찍으면 등록됨 -> 여기까지는 문제 없음
    // 판촉행사 시작 했는데 난리났음 -> 이 시스템은 처음부터 3개만을 구매할 수 있게 만들어 놨음
    // 나머지 997개는 구매를 처리하는 함수가 없음.

    // 1. 어떠한 제품이 들어와도 구매가 가능하게
    // 단, 모든 제품은 Product를 상속한다는 조건, 함수마다의 로직은 동일해야 함(함수마다 반복이여야 공통분모 뽑아서 쓰지)
    // 문제) Buyer 클래스의 코드를 수정해봐라
    // Hint) 오버로딩 개념 + 다형성 개념

    class Program
    {
        static void Main(string[] args)
        {
            // 매장에 제품 3개 갖다 놓음
            KtTv tv = new KtTv();
            Audio audio = new Audio();
            NoteBook notebook = new NoteBook();

            // 고객 생성
            Buyer buyer = new Buyer();

            // 구매 행위
/*          buyer.AudioBuy(audio);
            buyer.NoteBookBuy(notebook);
            buyer.KttvBuy(tv);
            buyer.KttvBuy(tv);
            buyer.KttvBuy(tv);
            buyer.KttvBuy(tv);*/

            // 오버로딩하면 그냥 Buy만 알면 되지
            buyer.Buy(audio);
            buyer.Buy(notebook);
            buyer.Buy(tv);
            buyer.Buy(tv);

        }
    }
}
