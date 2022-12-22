using System;
public class PrimeN
{
    public static void Main()
    {
        int Output, x ,y ;
        int LowEnd, HighEnd;

        Console.Write("Input the starting range or number : ");
        LowEnd = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the ending range of number : ");
        HighEnd = Convert.ToInt32(Console.ReadLine());
        Console.Write("The Prime numbers within the given range : ");
        for (Output = LowEnd; Output <= HighEnd; Output++)
        {
            x = 0;
            for (y = 2; y <= Output / 2; y++)
            {

                if (Output % y == 0)
                {
                    x++;
                    break;
                }
            }

            if (x == 0 && Output != 1)
                Console.Write("{0} ", Output);

        }





    }
}
   


