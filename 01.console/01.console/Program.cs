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
            Console.WriteLine("Hello world!"); // "Hello world!"를 출력하는 코드
            Console.WriteLine("이홍규");       // 출력
            string str = Console.ReadLine();   // 키보드 입력을 받아서 str이라는 string 변수에 저장한다.

            // 변수 : 변하느느 숫자, 컴퓨터에서 사용할 데이터를 저장할 수 있는 곳.
            // 변수의 종류 : 데이터 타입(Data type)
            // int : 인티저, 정수, 소수점 없는 숫자, 32bit
            // float : 플로트, 실수, 소수점 있는 숫자, 32bit
            // string : 스트링, 문자열, 글자들을 저장
            // bool : 불 또는 불리언, ture/false를 저장

            //int a = 10; //a라는 인티저 변수에 10이라는 데이터를 넣는다.
            //long b = 5000000000; // 50억은 int에 넣을 수 없다. => int는 32비트이고 32비트로 표현가능한 숫자의 갯수는  2^32(4,294,967,296)개 이기 때문이다.
            //int c = -100;
            //int d = 2000000000;
            //int e = 2000000000;
            //int f = d + e;
            //Console.WriteLine(f);


            //// float의 단점 : 태생적으로 오차가 있을 수 밖에 없다.
            //float aa = 0.000123f;
            //float ab = 0.9999999999999f;
            //float ac = 0.0000000000001f;
            //float ad = ab + ac; // 결과가 1이 아닐 수도 있다.
            //Console.WriteLine(ad);

            //string str1 = "Hello";
            //string str2 = "안녕!";
            //string str3 = $"Hello {a}"; // "Hello 10"
            //Console.WriteLine(str3);
            //string str4 = str1 + str2; // "Hello안녕!"
            //Console.WriteLine(str4);

            //bool b1 = true;
            //bool b2 = false;

            //int level = 1;
            //int hp = 10;
            //float exp = 0.9f;
            //string name = "너굴맨";
            //string result = $"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp}다.";
            //Console.WriteLine(result);
            //Console.WriteLine($"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp}다.");

            //Console.Write("이름을 입력하세요 : ");
            //name = Console.ReadLine();
            //Console.Write($"{ name}의 레벨을 입력하세요 : ");
            //string temp = Console.ReadLine();



            //level = int.Parse(temp); // string을 int로 변경해주는 코드
            //// level = int.parse(temp); // string을 int로 변경해주는 코드(숫자로 바꿀 수 있을 때만 가능). 간단하지만 위험함.
            //int.TryParse(temp, out level); //string을 int로 벼경해주는 코드(숫자로 바꿀 수 없으면 0으로 끝난다.)
            //level = Convert.ToInt32(temp); // string을 int로 변경해주는 코드(숫자로 바꿀 수 있 때만 가능). 더 세세하게 변경가능.
            //result = $"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp}다.\n";



            //exp = 0.959595f;
            //// 너굴맨의 레벨은 1이고 HP는 10이고 exp는 90%이다.

            //result = $"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp * 100:F3}%다.\n";
            //Console.WriteLine(result);

            //// 너굴맨의레벨은 1이고 hp는 10이고 exp는 0.9다.

            //string str5 = "너굴맨";
            //string str6 = "레벨 1";
            //string str7 = "hp 10";
            //string str8 = "exp 0.9";
            //string str9 = $"너굴맨 {a}";
            //Console.WriteLine(str9);
            //string str10 = str5 + str6 + str7 + str8;
            //Console.WriteLine(str10);


            //Console.Write("이름을 입력하세요 : ");
            //name = Console.ReadLine();
            //Console.Write($"{name}의 레벨을 입력하세요 : ");
            //string temp1 = Console.ReadLine();
            //level = int.Parse(temp1);
            //int.TryParse(temp1, out level);
            //level = Convert.ToInt32(temp1);
            //string temp2 = Console.ReadLine();

            //hp = int.Parse(temp2);
            //int.TryParse(temp2, out hp);
            //hp = Convert.ToInt32(temp2);
            //Console.Write($"{name}의 hp를 입력하세요 : \n");
            //Console.Write($"{name}의 exp를 입력하세요 : ");


            //Console.Write("이름을 입력하세요 : ");
            //name = Console.ReadLine();

            //string temp4;
            //Console.Write("레벨을 입력하세요 : ");
            //temp4 = Console.ReadLine();
            //int.TryParse(temp4, out level);

            //Console.Write("HP를 입력하세요 : ");
            //temp4 = Console.ReadLine();

            //Console.Write("경험치를 입력하세요 : ");
            //temp4 = Console.ReadLine();
            //float.TryParse(temp4, out exp);



            string result;
            string name = "너굴맨";
            int hp = 2;
            int level;
            float exp;


            //result = $"{name}의 레벨은 {level}이고 HP는 {hp}이고 exp는 {exp}다.\n";
            //Console.WriteLine(result);


            //변수 끝 -----------------------------------------------------------------------------------------



            // 제어문(Control statement)
            // 실행되는 코드 라인을 변경할 수 있는 코드

            hp = 5;
            if (hp < 3) // hp가 2이기 떄문에 참이다. 따라서 중괄호 사이에 코드가 실행된다.
            {
                Console.WriteLine("HP가 부족합니다."); //참일 때 실행되는 코드
            }
            else
            {
                Console.WriteLine("HP가 충분합니다."); //거짓일 떄 실행되는 코드

            }
            Console.ReadKey();                 // 키 입력 대기하는 코드
        }
    }
}
