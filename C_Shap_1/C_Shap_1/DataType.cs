using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

    Literal Data(리터럴 데이터)
        프로그램에 직접 표현한 값

    C#에서 리터럴 데이터를 사용할 때, 별도의 접미어 표시(Suffix)가 없는 경우
    C# 컴파일러는 int, double, char, string, bool 데이터 타입에 기본적으로 그 값을 할당한다.

    [디폴트 리터럴 타입]
    123 // int 리터럴
    12.3 // double 리터럴
    "A" // string 리터럴
    'a' // char 리터럴
    true // bool 리터럴 

    특정 데이터 타입을 지정하고자 할 경우
        => 리터럴 데이터 뒤에 1~2자의 타입 지정 접미어(Suffix)를 추가해야 한다.
           Suffix는 대소문 구분 하지 않음...
    
*/


namespace C_Shap_1
{
    class DataType
    {
        /*
        static void Main(string[] args)
        {

            // Bool
            bool b = true;

            // Numeric
            short sh = -32768;
            int i = 2147483647;
            long l = 1234L;         // L sfuffix
            float f = 123.45F;      // F suffix
            double d1 = 123.45;
            double d2 = 123.45D;    // D suffix
            decimal d = 123.45M;    // M suffix

            // Char/String
            char c = 'A';
            string s = "Hello";

            // DataTime 2011-10-30 12:35
            DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

            // 최대값, 최소값
            // 숫자형 데이터 타입의 최대값 혹은 최소값을 알아내기 위해 사용
            int i2 = int.MaxValue;
            float f2 = float.MinValue;

            // null
            // 데이터 타입은 null을 가질 수 있는 타입(Reference type)과 
            // 가질 수 없는 타입(Value type)으로 구분 될 수 있다.
            string s1;
            s1 = null;

            // Nullable Type
            // 정수(int)나 날짜(DateTime)와 같은 Value type은 일반적으로 null을 가질 수 없다.
            // C# 2.0에서부터 이러한 타입들에 null을 가질 수 있게 한 것.

            // 물음표(?)를 int나 DateTime 타입명 뒤에 붙이면 Nullable Type이 된다.
            // 이는 컴파일하면 .NET의 Nullable<T> 타입으로 변환된다.
            // Nullable Type을 일반 Value Type으로 변경하기 위해서는 Nullable의 .Value 속성을 사용한다.

            // Nullable 타입
            int? i3 = null;
            i3 = 101;

            bool? b2 = null;

            // int?를 int로 할당
            Nullable<int> j = null;
            j = 10;
            int k = j.Value;

        }
        */
    }
}

