// вывести нат числа от N до 1
System.Console.Write("Input N: ");
int N = int.Parse(Console.ReadLine());

void Numbers(int N)
{
    if(N > 0)
    {
        System.Console.WriteLine(N);
        Numbers(N-1);
    }
}

Numbers(N);