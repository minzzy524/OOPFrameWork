/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            bool IsAvailableRRN(string RRN)

            {

                //공백 제거

                RRN = RRN.Replace(" ", "");

                //문자 '-' 제거

                RRN = RRN.Replace("-", "");

                //주민등록번호가 13자리인가?

                if (RRN.Length != 13)

                {

                    return false;

                }



                int sum = 0;

                for (int i = 0; i < RRN.Length - 1; i++)

                {

                    char c = RRN[i];

                    //숫자로 이루어져 있는가?

                    if (!char.IsNumber(c))

                    {

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

                    return false;

                }

                return true;

            }
        }
    }
}
*/