using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_try_catch_finally
{



    class Program
    {
        static void Main(string[] args)
        {
            try { 
                // 예외를 강제로 던지기
                throw new IndexOutOfRangeException("배열이 문제가 생겼네"); 
            
            }
            catch (Exception e){
                // throw 발생한 예외 확인
                Console.WriteLine(e.Message);
                Console.WriteLine("---------------------");
                Console.WriteLine(e.Source);
                Console.WriteLine("---------------------");
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("---------------------");
                Console.WriteLine(e.ToString());
            }
            finally{ // 강제로 실행하는 블록
                Console.WriteLine("---------------------");
                Console.WriteLine("Power off");
            }
        }
    }
}
