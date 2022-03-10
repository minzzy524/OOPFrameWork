using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Teamwork_poly
{
    class Product : Object
    {
        public int price;
        public Product() { }
        public Product(int price)
        {
            this.price = price;
        }
    }
    //제품 종류
    class Tv : Product
    {
        public Tv() : base(500) //가격
        {

        }
        public override string ToString()
        {
            return "Tv";
        }

    }

    class PC : Product
    {
        public PC() : base(500)
        {

        }

        public override string ToString()
        {
            return "PC";
        }

    }

    class Laptop : Product
    {
        public Laptop() : base(500)
        {

        }

        public override string ToString()
        {
            return "Laptop";
        }

    }


    class Buyer
    {
        private int money = 1000000; //소지금액
        public Product[] cart = new Product[10]; //카트에 담은 제품 및 가격
        public int product; //현재 카트에 담은 제품 수량
        public int sum; //카트에 있는 총제품 가격

        public Buyer() : this(100000)
        {

        }
        public Buyer(int money)
        {
            this.money = money;
            Console.WriteLine($"현재 금액은 {this.money}원 입니다\n");
        }


        public void Buy(Product n) //Tv 객체의 주소
        {
            if (product < 10) // 제품이 10개 이하일때 담을 수 있음
            {
                cart[product] = n;
                Console.WriteLine("구매한 물건은 :" + n.ToString());
                Console.WriteLine($"현재 카트에 {product + 1}개 담았습니다\n\n");
                product++; // 구매한 갯수 증가

            }

            else if (product >= 10) // 넘는 경우 
            {
                Console.WriteLine("카트가 다 찼습니다\n");
                return;
            }

        }

        public void summery() //카트에 담은 제품 구매 시 가격 및 제품 명
        {
            if (product <= 10)
            {
                if (product >= 1)
                {
                    for (int i = 0; i < product; i++)
                    {
                        Console.WriteLine($"{i + 1}번칸에 {cart[i].ToString()} : {cart[i].price}원 입니다.");
                        sum += cart[i].price;
                        Console.WriteLine();
                    }
                    Console.WriteLine($"총 금액은 : {sum}입니다\n");
                    Console.WriteLine("구매하시겠습니까? 1. 구매 2. 취소\n");
                    int select = Convert.ToInt32(Console.ReadLine());
                    if (select == 1)
                    {
                        if (sum <= money)
                        {
                            money = money - sum;
                            Console.WriteLine("구매가 완료되었습니다.\n");
                            Console.WriteLine($"잔액은 {money}입니다.\n");
                        }
                        else
                        {
                            Console.WriteLine("잔액이 부족합니다.\n");
                        }

                    }
                    else if (select == 2)
                    {
                        Console.WriteLine("구매가 취소되었습니다.\n");
                    }
                    product = 0;
                    sum = 0;
                }
                else
                {
                    Console.WriteLine("물건을 담지 않았습니다.\n");
                }
            }
            else
            {
                return;
            }

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Product tv = new Tv();
            Product laptop = new Laptop();
            Product pc = new PC();

            Buyer buyer = new Buyer();

            buyer.Buy(tv);
            buyer.Buy(tv);
            buyer.Buy(laptop);
            buyer.Buy(pc);
            buyer.Buy(tv);
            buyer.Buy(tv);
            buyer.Buy(tv);
            buyer.Buy(laptop);
            buyer.Buy(pc);
            buyer.Buy(tv);

            buyer.summery();


        }
    }
}
