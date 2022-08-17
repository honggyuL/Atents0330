using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumResult = Sum(10, 20); // break point (단축키 F9)
           
            Console.ReadKey();                 // 키 입력 대기하는 코드
        } //main 함수의 끝

        // 함수의 구성요소
        // 이름 : 함수들을 구분하기 위한 이름 (예제의 Sum)
        // 리턴타입 : 함수의 실행 결과로 돌려주는 데이터의 타입 (int, 함수의 이름앞에 표시된다.)
        // 파라메터(매개변수) : 함수가 실행될 때 외부에서 받는 값 (예제의 (int a, int b) 두개의 파라메터가 있다. 함수 이름 뒤에 표시된다.)
        // 함수바디 : 함수가 호출될 때 실행될 코드 (예제의 { ~ } 라인)

        // 함수의 이름, 리턴타입, 파라메터를 합쳐서 함수 프로토타입. 함수의 주민등록번호. 절대로 하나의 프로그램안에서 겹치지 않는다.

        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }


        void Print()     //리턴해주는 값이 없고, 파라메터도 없는 경우
        {
            Console.WriteLine("Print");
        }

        
    }
}
