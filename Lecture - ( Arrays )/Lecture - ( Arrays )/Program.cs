using System;
using System.Runtime.ExceptionServices;
namespace ABC
{
    class A
    {
        static void Main(String[] args)
        {
            //Declare and initializing an array for 1-D

            /*First Way*/
            int[] a = new int[2];
            a[0] = 10;
            a[1] = 20;

            /*Second Way*/
            int[] b = new int[2] {100,73};

            /*Third Way*/
            int[] c = { 219, 100, 21, 6 };

            //Declaration for 2-D & 3-D & u can pass elements like this too . Its also known as recntangular array
            int[,] d = new int[3, 4] { { 44, 12 }, { 66,19} };
            int[,,] _d = new int[3, 4,6];

        }
    }
}
