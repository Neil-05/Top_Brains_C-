public class Program
{
    public static void Main(string[] args)
    {   Console.WriteLine("Enter a number:");
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Another number for range:");
        int r=int.Parse(Console.ReadLine());
        for(int i=n;i<=r;i++)
        {
        int temp=i;
        int sum=0;
        int count=0;
        while(temp>0)
        {
            int d=temp%10;
            sum +=d;
            count++;
            temp=temp/10;
        }
        int sq= i*i;
        int sum2=0;
        while(sq>0)
        {
            int d2=sq%10;
            sum2 +=d2;
            sq=sq/10;
        }
        if(sum*sum == sum2)
        {
            Console.WriteLine(i+" ,This is a Lucky Number");
        
        }
       
    }
    }
}