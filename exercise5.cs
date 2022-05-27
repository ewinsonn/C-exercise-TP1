using System;

class Pi
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine(" CHRISTMAS TREE : ");
        int t = Convert.ToInt32(Console.ReadLine());
        christmasTree(t);
    }
    public static void christmasTree(int N)
    {

        int j = 0;
        if (N <= 20 && N >= 3)
        {
            Console.WriteLine("------  Regular tree -----");
            for (int i = 1; i <= N; ++i, j = 0)
            {
                for (int k = 1; k <= N - i; ++k)
                {
                    Console.Write(" ");
                }

                while (j != 2 * i - 1)
                {
                    Console.Write("*");
                    ++j;
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= N * 2 - 1; i++)
            {
                if (i == N - 1 || i == N + 1)
                    Console.Write('|');
                else
                    Console.Write(' ');
            }

            Console.WriteLine();
            Console.WriteLine("------  Decorated tree -----");
            int p = 0;
            for (int i = 1; i <= N; ++i, j = 0)
            {
                p = i % 3;
                for (int k = 1; k <= N - i; ++k)
                {
                    Console.Write(" ");
                }

                while (j != 2 * i - 1)
                {
                    if (j % 6 == p)
                    {
                        if (j % 5 == p)
                            Console.Write('i');
                        else
                            Console.Write('o');
                    }
                    else
                        Console.Write("*");

                    ++j;
                }

                Console.WriteLine();
            }

            for (int i = 1; i <= N * 2 - 1; i++)
            {
                if (i == N - 1 || i == N + 1)
                    Console.Write('|');
                else
                    Console.Write(' ');
            }


        }
        else
            Console.WriteLine("Wrong Answer : between 3 and 20");
    }
}