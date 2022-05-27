using System;

class Pp
{
    static void Main(string[] args)
    {
        Console.Write("\n\n");
        Console.Write("prime number between 1 and 1000:\n");
        Console.Write("\n\n");
        Prime();
        Console.Write("\n\n");

        Console.Write("Enter the nth number of the Fibonacci Series: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write(F(c));
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine(" Factorial function");
        Console.WriteLine("enter your number :");
        int t = Convert.ToInt32(Console.ReadLine());
        factorial(t);
        Console.ReadKey();


    }



    static void Prime() //  
    {
        for (int num = 1; num < 1000; num++)
        {
            int ctr = 0;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    ctr++;
                    break;
                }
            }
            if (ctr == 0 && num != 1)
                Console.Write("{0} ", num);
        }





    }
    public static int F(int N)
    {
        if (N == 0) return 0;
        else if (N == 1) return 1;
        else
        {
            return F(N - 1) + F(N - 2);
        }
    }
    public static void factorial(int N)
    {
        int result = 1;
        for (int i = N; i > 0; i--)
        {
            result = result * i;
        }

        Console.WriteLine("{0}! = {1}", N, result);
    }
}



