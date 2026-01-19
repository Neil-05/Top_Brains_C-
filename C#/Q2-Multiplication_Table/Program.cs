public class Program
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("Enter a number to print its multiplication table:");
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a range up to which the table should be printed:");
        int r=int.Parse(Console.ReadLine());
        List<int> table = new List<int>();
        for(int i = 0; i < r; i++)
        {
            table.Add(n * (i + 1));
        }
        Console.WriteLine("Multiplication Table -----");
        Console.WriteLine("[" + string.Join(",", table) + "]");

    }

}