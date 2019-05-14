using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    
    C# 변수는 메서드 안에서 해당 메서드의 로컬변수로 선언되거나,
    혹은 클래스 안에서 클래스 내의 멤버들이 사용하는 전역적 변수(Filed)로 선언 될 수 있다.

    로컬 변수   :   해당 메서드내에서만 사용 되며, 메서드 호출이 끝나면 소멸
                   반드시 사용 전에 값을 할당해야 한다.

    Filed : 클래스 객체가 살아있는 한 계속 존속하며, 또한 다른 메서드들에서 필드를 참조 할 수 있다.
            값을 할당하지 않으면, 해당 타입의 기본값이 자동으로 할당된다.

    주의!!
        만약 필드가 정적 필드(static field)이면 클래스 Type이 처음으로 런타임에 의해 로드 될 떄
        해당 Type 객체에 생성되어 프로그램이 종료 될 때까지 유지된다.

    모근 C# 변수의 이름은 대소문자를 구별(case-sensitive)한다.
    
*/
/*
namespace C_Shap_1
{
    class Valiable
    {
        // 필드 (클래스 내에서 공통적으로 사용되는 전역 변수)
        // 여기서 전역(Global)의 의미는 객체(혹은 클래스) 내에서의 전역을 의미한다.
        int globalVar;
        const int MAX = 1024;

        public void Method1()
        {
            // 로컬 변수
            int localVar;

            // 아래 할당이 없으면 에러 발생.
            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }

    class Program
    {
        // 모든 프로그램에서는 Main()이 있어야 함.
        static void Main(string[] args)
        {
            // 객체 생성
            Valiable obj = new Valiable();
            obj.Method1();
        }
    }
}
*/

/*
 
   C# 상수는 C# 키워드 const를 사용하여 정의한다.
  
    상수는 초기에 정한 값을 중간에 변경할 수 없다.

    const 대신 readonly 키워드를 사용하여 읽기전용(개념적으로 상수와 비슷) 필드를 만들 수 있다.
    readonly는 필드 선언부나 클래스 생성자에서 그 값을 지정할 수 있고, 런타임시 값이 결정된다.

*/
/*
namespace C_Shap_1
{
    class CSVar
    {
        // 상수
        const int MAX_VALUE = 1024;

        // readonly 필드
        readonly int Max;
        public CSVar()
        {
            Max = 1;
        }
    }
}
*/