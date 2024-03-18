

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 5, 8, 12, 76, 101};

        Console.WriteLine(Max(arr));
    }

    public static int Max(int[] num)
    {
        int max = 0;

        for(int i = 0; i < num.Length; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
            }
        }

        return max;
    }
}