public class Program
{
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        int temp=n;
        int sum=0;
        int count=0;
        while(temp>0)
        {
            int d=temp%10;
            sum +=d;
            count++;
            temp=temp/10;
        }
        int sq= n*n;
        int sum2=0;
        while(sq>0)
        {
            int d2=sq%10;
            sum2 +=d2;
            sq=sq/10;
        }
        if(sum*sum == sum2)
        {
            Console.WriteLine("This is a Lucky Number");
        
        }
        else
        {
            Console.WriteLine("This is not a Lucky Number");
        }
    }
}