int GetLengthOfNumber (int val)
{
    int count = 0;
    while (val > 0)
    {
        val = val / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int length = GetLengthOfNumber (N);
int [] digitsOfNumber = new int [length];

int Number = N;
for (int i = 0; i < length; i++)
{
    digitsOfNumber [i] = Number % 10;
    Number = Number / 10;
}

int sum = 0;
for (int j = 0; j < length; j++)
    if (digitsOfNumber[j] == 0)
    {
        sum = sum + 0;
    }
    else if (N % digitsOfNumber[j] == 0)
    {
        sum = sum + digitsOfNumber[j];
    }

    Console.Write("Сумма: ");
    Console.WriteLine(sum);