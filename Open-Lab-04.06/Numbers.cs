using System;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
              for (int i = 0; i <= 100; i++)
        {
            if (IsEven(i))
            {
                Console.WriteLine(i);
            }
        }
              public static bool IsEven(int value)
       {
        return value % 2 == 0;
        }
        }
    }
}
