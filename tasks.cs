using System;

public class Tasks
{
    // Раздел 1
    public double Fraction(double x)
    {
        return x - (int)x;
    }

    public int CharToNum(char x)
    {
        return x - '0';
    }

    public bool Is2Digits(int x)
    {
        return (x >= 10 && x <= 99) || (x >= -99 && x <= -10);
    }

    public bool IsInRange(int a, int b, int num)
    {
        return num >= Math.Min(a, b) && num <= Math.Max(a, b);
    }

    public bool IsEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    // Раздел 2
    public int Abs(int x)
    {
        if (x < 0) return -x;
        return x;
    }

    public bool Is35(int x)
    {
        if (x % 3 == 0 && x % 5 != 0) return true;
        if (x % 5 == 0 && x % 3 != 0) return true;
        return false;
    }

    public int Max3(int x, int y, int z)
    {
        int max = x;
        if (y > max) max = y;
        if (z > max) max = z;
        return max;
    }

    public int Sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19) return 20;
        return sum;
    }

    public string Day(int x)
    {
        switch (x)
        {
            case 1: return "понедельник";
            case 2: return "вторник";
            case 3: return "среда";
            case 4: return "четверг";
            case 5: return "пятница";
            case 6: return "суббота";
            case 7: return "воскресенье";
            default: return "это не день недели";
        }
    }

    // Раздел 3
    public string ListNums(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i++)
        {
            result = result + i + " ";
        }
        return result.Trim();
    }

    public string Chet(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i = i + 2)
        {
            result = result + i + " ";
        }
        return result.Trim();
    }

    public int NumLen(long x)
    {
        int count = 0;
        do
        {
            x = x / 10;
            count++;
        }
        while (x != 0);
        return count;
    }

    public void Square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void RightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 0; j < x - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    // Раздел 4
    public int FindFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) return i;
        }
        return -1;
    }

    public int MaxAbs(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (Math.Abs((long)arr[i]) > Math.Abs((long)max))
            {
                max = arr[i];
            }
        }
        return max;
    }

    public int[] Add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];
        for (int i = 0; i < pos; i++) result[i] = arr[i];
        for (int i = 0; i < ins.Length; i++) result[pos + i] = ins[i];
        for (int i = pos; i < arr.Length; i++) result[i + ins.Length] = arr[i];
        return result;
    }

    public int[] ReverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }
        return result;
    }

    public int[] FindAll(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) count++;
        }

        int[] result = new int[count];
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result[k] = i;
                k++;
            }
        }
        return result;
    }
}
