using System;

class Po
{
    static void Main(string[] args)
    {
      Console.WriteLine();
   Console.WriteLine(" try/catch :F(x) = x²-4 With -3 <= x <= 3");
   for (int i = -3; i <= 3; i++) {
    Console.WriteLine(PowerFunction(i));
     }
  }


   public static int PowerFunction(int x)
        {

            int res = 0;
            if (x <= 3 && x >= -3)
            {
                try
                {
                    res = 10/(int)(Math.Pow(x, 2) -4);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return res;
        }
}
