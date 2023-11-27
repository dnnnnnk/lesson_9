// функция аккермана 
System.Console.Write("input M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("input N: ");
int N = Convert.ToInt32(Console.ReadLine());
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
Console.WriteLine("Akkermann({0}, {1}) = {2}", M, N, Akkerman(M, N));