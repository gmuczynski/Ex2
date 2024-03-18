public class Program
{
    public static void Main(string[] args)
    {
        List<Int32> array = new List<int>();

        foreach (var arg in args)
        {
            int num = 0;
            if (int.TryParse(arg, out num))
            {
                array.Add(num);
            }
        }
        
        Console.WriteLine(Avg(array));
    }
    
    public static double Avg(List<Int32> array)
    {
        return array.Average();
    }
}