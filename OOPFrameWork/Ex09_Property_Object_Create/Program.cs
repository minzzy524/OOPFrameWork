using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Property_Object_Create
{
    class BirthdayInfo
    {   // 생성자가 없어요
        // property를 통해서 객체 생성 시 초기화 작업이 가능하다
        /* 객체를 생성할 때 각 필드를 초기화하는 다른 방법입니다.
        클래스이름 인스턴스 = new 클래스이름()
        {
            프로퍼티1 = 값,
            프로퍼티2 = 값,
            프로퍼티3 = 값
        };*/




        public string Name
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*            BirthdayInfo birth = new BirthdayInfo()
                        {
                            Name = "홍길동",
                            Birthday = new DateTime(1650, 2, 12)
                        };

                        Console.WriteLine("Name: {0}", birth.Name);
                        Console.WriteLine("Birthday: {0}", birth.Birthday.ToShortDateString());
                        Console.WriteLine("Age: {0}", birth.Age);*/

            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "홍길동",
                Birthday = new DateTime(2022, 1, 1)
            }; // 반드시 기억하자

            Console.WriteLine("Name : {0}", birth.Name);
            Console.WriteLine("Birthday : {0}", birth.Birthday);
            Console.WriteLine("Age : {0}", birth.Age);

        }
    }

}
