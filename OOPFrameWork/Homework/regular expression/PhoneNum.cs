/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Homework.regular_expression
{
    *//* - @ : 문자열의 끝을 의미한다.
   - {} : { } 사이에 숫자를 쓰면 그 숫자 만큼 패턴이 반복됨을 의미한다.
     [A-C]{1,4}는 A,B,C 를 1개에서 4개 조합하면 된다. AAAA도 가능하고 A, BA, ABC, ACBA도 가능하다.
     예제 : [A-C]{1,3} 패턴은 AA(일치), CBC(일치), ADA(불일치), ACCC(불일치)이다.
   - [] : [ ] 사이에 있는 형식이 일치하는것을 의미한다. 즉 [AB] 는 A, B만일치, [A-Z] 는 A부터 Z중 하나의 문자와 일치한다.
     예제 : [A-C] 패턴은 A(일치), B(일치), AB(불일치), BC(불일치) 이다.          
    *//*


    class PhoneNum
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("휴대전화 번호를 입력하세요. ('-'제외)");
            string phoneNum = Console.ReadLine();
            
            if (phoneNum.Length == 10 || phoneNum.Length == 11)
            {
                Regex regex = new Regex(@"01{1}[016789]{1}[0-9]{7,8}");
                // 휴대폰 번호는 01로 시작하고, 010/016/017/018/019인 경우가 존재
                // 앞에 3자리를 제외한 가운데 번호가 세 자리인 일곱 자리(ex. 01x-xxx-xxxx)와 가운데 번호 4자리인 여덟 자리(01x-xxxx-xxxx)의 경우가 존재

                Match m = regex.Match(phoneNum);
                if (m.Success)
                {
                    Console.WriteLine("전화번호 맞음");
                }
                else
                {
                    Console.WriteLine("휴대전화 번호가 아님");
                }
            }
            else 
            {
                Console.WriteLine("자릿수가 맞지 않음");
            }
        }
    }
}
*/