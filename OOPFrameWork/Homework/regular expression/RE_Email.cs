/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace email
{
    class IsEmail
    {
        public IsEmail()
        {
            Console.WriteLine("이메일을 입력하세요");
            string email = Console.ReadLine();
            bool check = Check_email(email);

            if (check == true)
            {
                Console.WriteLine("형식에 맞는 이메일입니다.");
                Console.WriteLine(email);
            }
            else
            {
                Console.WriteLine("형식에 맞지않는 이메일 입니다");
            }
        }
        public static bool Check_email(string email)
        {
            Regex regex = new Regex(@"^([0-9a-zA-Z]+){3,}@([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+){1,}$");
            // ^ : 문장의 시작이 다음을 만족, ([0-9a-zA-Z]+){3,} 값이 숫자 및 영문자 사이의 3개 이상,
            // @ : @문자 필수,([0-9a-zA-Z]+)값이 숫자 및 영문자 사이의 1개 이상, (\.[0-9a-zA-Z]+){1,} . 뒤에 숫자 및 영문자 1번 이상 반복

            return regex.IsMatch(email);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IsEmail Isemail = new IsEmail();

        }


    }
}*/