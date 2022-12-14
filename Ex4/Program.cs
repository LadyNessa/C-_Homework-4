Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Number = N;

int sum = 0;
int result = 0;
while (N > 0)
{
    result = N % 10;
    if (result == 0)
    {
        sum = sum + 0;
    }
    else if (Number % result == 0)
    {
        sum = sum + result;
    }  
    N = N / 10;
}
Console.Write("Сумма: ");
Console.WriteLine(sum);

