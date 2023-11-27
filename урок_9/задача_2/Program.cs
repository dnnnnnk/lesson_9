// сумма нат чисел от M до N
System.Console.Write("input M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("input N: ");
int N = Convert.ToInt32(Console.ReadLine());
int summ = 0;
void Numbers(int N, int M)
{
    if (M <= N)
    {
        summ+=M;
        Numbers(N,M+1);
    }
}
Numbers(N, M);
System.Console.WriteLine(summ);