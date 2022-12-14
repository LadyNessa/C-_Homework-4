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

int [] array = new int [10];

int i = 0;
while (i < 10)
{
    int Number = new Random().Next(1, 1000); 
    
    int length = GetLengthOfNumber (Number);
    int [] digitsOfNumber = new int [length];
        
    int N = Number;    
    for (int j = 0; j < length; j++)
    {
            digitsOfNumber [j] = N % 10;
            N = N / 10;
    }

    int sum = 0;
    int composition = 1;
    int k = 0;
    while (k < length)
    {
        composition = composition * digitsOfNumber[k];
        sum = sum + digitsOfNumber[k];
        k++;
    }

    if (composition > 0)
    {
        if (composition % sum == 0)
        {
            array[i] = Number;
            Console.WriteLine(array[i] + " ");
            i++;
        }
    }
}
