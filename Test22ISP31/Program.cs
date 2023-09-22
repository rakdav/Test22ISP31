
MyMath myMath = new MyMath();
Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(myMath.Factorial(n));
public class MyMath
{
    public long Factorial(int n)
    {
        long F = 1;
        for (int i = 1; i <= n; i++) F *= i;
        return F;
    }
    public int Sum(int x,int y)
    {
            return x + y;
    }
}

