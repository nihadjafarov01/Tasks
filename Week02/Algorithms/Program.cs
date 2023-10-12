namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Verilən ədədə və ya ondan böyük ən yaxın ədədə qədər fibonaççi ardıcıllığını ekrana çap edin.
            int eded = 378;
            int n_2 = 0;
            int n_1 = -1;
            int n = 1;
            while (n < eded)
            {
                n_2 = n_1;
                n_1 = n;
                n = n_2 + n_1;
                Console.WriteLine(n);
            }
            //1

            ////2. 2 dəyişənin dəyərlərini 3cü dəyişən istifadə etmədən dəyişin.
            //int a = 12;  // a = 47
            //int b = 47;  // b = 12

            //a = a + b;
            //b = a - b;
            //a = a - b;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            ////2 
            
        }
    }
}