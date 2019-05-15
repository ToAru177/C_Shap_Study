using System;

namespace C_Shap_1
{
    class String
    {

    }

    class Program
    {
        static  void Main(string[] args)
        {
            // 문자열(string) 변수
            string s1 = "C#";
            string s2 = "Programming";

            // 문자(char) 변수
            char c1 = 'A';
            char c2 = 'B';

            // 문자열 결합
            string s3 = s1 + " " + s2;
            Console.WriteLine("String : {0}", s3);

            // 부분 문자열 발췌
            // .Substring(시작 위치, 출력 문자수)
            string s3substring = s3.Substring(1, 5);
            Console.WriteLine("Substring : {0}", s3substring);
        }
    }
}
