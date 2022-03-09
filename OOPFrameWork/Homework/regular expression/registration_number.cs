/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Homework.regular_expression
{
    *//*
      # 1번 자리 : 성별 (ex. 남자 : 1 or 3, 여자 : 2 or 4)
        - 00년 이후 출생자부터는 남자는 3 여자는 4.
      # 2~5번 자리 : 출생 신고 당시의 거주지 관할 동사무소의 지역코드
      # 6번 자리 : 출생 신고 날짜
      # 7번 자리 : 검정 코드

      # 1. 검정 코드인 7을 제외한 각자리에 미리 지정된 값(234567892345)을 각각 곱함.
      # 2. 각 자리에서 곱한 결과를 모두 더함.
      # 3. 더한 결과(206)을 11로 나누어 줌(% 나머지 연산).
      # 4. 11에서 나머지의 결과를 빼줌.
      # 5. 나머지 3과 검증코드 7이 같은지 확인. 같으면 유효한 주민등록번호.
      # string Resident Registration Number= @"[0-9]{6}-[0-9]{7}"
    *//*

    class registration_number
    {

        static void Main(string[] args)
        {

            Console.WriteLine("주민번호를 입력하세요");
            string num = Console.ReadLine();

            bool IsAvailableRRN(string RRN)
            {
                //공백 제거
                RRN = RRN.Replace(" ", "");
                //문자 '-' 제거
                RRN = RRN.Replace("-", "");

                //주민등록번호가 13자리인가?
                if (RRN.Length != 13)
                {
                    Console.WriteLine("13자리를 입력하세요");
                    return false;
                }

                int sum = 0;
                for (int i = 0; i < RRN.Length - 1; i++)
                {
                    char c = RRN[i];
                    //숫자로 이루어져 있는가?
                    if (!char.IsNumber(c))
                    {
                        Console.WriteLine("숫자를 입력하세요");
                        return false;
                    }
                    else
                    {
                        if (i < RRN.Length)
                        {
                            //지정된 숫자로 각 자리를 나눈 후 더한다.
                            sum += int.Parse(c.ToString()) * ((i % 8) + 2);
                        }
                    }
                }

                // 검증코드와 결과 값이 같은가?
                if (!((((11 - (sum % 11)) % 10).ToString()) == ((RRN[RRN.Length - 1]).ToString())))
                {
                    Console.WriteLine("형식에 맞는 주민번호가 아닙니다.");
                    return false;
                }
                Console.WriteLine("형식에 맞는 주민번호 입니다.");
                return true;
            }
            IsAvailableRRN(num);
        }
    }
}

*/