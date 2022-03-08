using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_try_catch
{
    // 예외처리 : 개발자가 코드를 통해서 문제를 발생
    // 개선의 여지가 있다.
    // 내가 만든 코드가 문제가 있을까? 확신이 없어
    // try catch finally
    // 코드를 수정하는 것이 아니고, 프로그램이 강제로 죽는 것을 방지한다.
    // 문제를 인지하고 추후에 코드는 수정해야 한다.


    class Program
    {
        static void Main(string[] args)
        {
            /*            string str = null; // 주소가 없다
                        Console.WriteLine(str.ToString()); // 예외 발생(null은 Tostring 할 수 없음) >> System.NullReferenceException >> 프로그램 강제 종료 >> 뒤에 "성공 종료"까지 못감 
                        Console.WriteLine("성공 종료");*/

            // 처리되지 않은 예외: System.NullReferenceException: 개체 참조가 개체의 인스턴스로 설정되지 않았습니다.
            // 위치: Ex06_try_catch.Program.Main(String[] args) 파일 C:\Users\MAC\source\repos\minzzy524\OOPFrameWork\OOPFrameWork\Ex06_try_catch\Program.cs:줄 22

            string str = null;
            try
            {
                Console.WriteLine(str.ToString()); // 문제가 발생

                // 내부적으로 예외를 담을 수 있는 객체가 자동 생성되고, 그 객체에 문제를 담고 그 주소를 Exception e 에 전달한다
                // 


            }
            catch (NullReferenceException e){ // 가독성을 높이기 위해 하위 예외 먼저 해놓자. 상위 예외가 뒤에

                Console.WriteLine(e.Message);
                // 1. log 파일에 정보 기록 >> 수정
                // 2. 메일 시스템 연동 -> 문제를 담당자에게 메일 >> 수정
            }
            

            catch (Exception n) // 문제 생기면 나는 catch 블록으로 가겠다.
            {
                Console.WriteLine(n.Message);
            }
            Console.WriteLine("성공 종료"); // 문제가 생겨도 일단 프로그램 죽이지 않고 돌려는 줄게

        }
    }
}
