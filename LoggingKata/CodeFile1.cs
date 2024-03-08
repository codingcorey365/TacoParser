using System;

public class Kata
{
    public static bool IsSquare(int n)
    {
        if (n < 0)
        {
            return false;
        }

        if (IsInteger(n))
        {
            double x = Math.Sqrt(n);
            double y = x * x;

            if (IsInteger(x))
            {
                if (y == n)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        else
        {
            return false;
        }

        return true;
    }
}