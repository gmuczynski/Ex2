public class Program
{
    public static void Main(string[] args)
    {
        List<Int32> array = new List<int>();

        foreach (var arg in args)
        {
            int num = 0;
            //Console.WriteLine(arg);
            if (int.TryParse(arg, out num))
            {
                //Console.WriteLine(num);
                array.Add(num);
            }
        }
        
        Console.WriteLine(array.Average());
    }
}