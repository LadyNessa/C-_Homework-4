Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;

for (int count = 1; count < B; count++)
{
    result = result * A;
}
Console.Write("Итог: ");
Console.WriteLine(result);