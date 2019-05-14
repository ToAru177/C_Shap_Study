using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
    배열 : 일련의 동일한 데이터 타입 요소들로 구성된 데이터 집합
           인덱스를 통하여 개개의 배열요소(Element)를 엑세스 할 수 있다.

    C#에서 배열은 Zero-based Array => 첫번째 요소가 인덱스 0을 갖는다.

    C# 배열은 최고 32차 배열을 가질 수 있다.

    2차 이상의 다차원 배열은 
    각 차원별 요소 크기가 고정된 "Rectangular 배열"
    각 차원별 크기가 서로 다른 "가변 배열"로 나뉨.

*/
namespace C_Shap_1
{
    class Array
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 80, 70, 60, 90, 100 };
            int sum = CalculateSum(scores); // 배열 전달 : 배열명 사용

            Console.WriteLine(sum);
        }

        static int CalculateSum(int[] scoresArray)  // 배열 받는 쪽
        {
            int sum = 0;
            for (int i = 0; i < scoresArray.Length; i++)
                sum += scoresArray[i];

            return sum;
        }

        /*
        static void Main(string[] args)
        {
            int sum = 0;
            int[] score = { 80, 70, 60, 90, 100 };

            // 배열 score의 사이즈를 구하기 위하여 .Length 속성 사용
            for (int i = 0; i < score.Length; i++)
                sum += score[i];

            Console.WriteLine(sum);
        }
        */

        /*
        static void Main(string[] args)
        {
            // Jangged Array(가변 배열)
            // 1차 배열 크기(3)는 명시해야 한다.
            int[][] A = new int[3][];

            //각 1차 배열 요소당 서로 다른 크기의 배열 할당 가능
            A[0] = new int[2];
            A[1] = new int[3] { 1, 2, 3 };
            A[2] = new int[4] { 1, 2, 3, 4 };

            A[0][0] = 1;
            A[0][1] = 2;
        }
        */


        /*
        static void Main(string[] args)
        {
            // 1차원 배열
            string[] players = new string[10];
            string[] Regions = { "서울", "경기", "부산" };

            // 2차원 배열 선언 및 초기화
            string[,] Depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

            // 3차원 배열 선언
            string[,,] Cubes;
        }
        */
    }
}
