// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] InitArray()
{
    double[] result = new double [10];
    Random rnd = new Random();
    for (int i = 0; i < 10; i++)
    {
        result[i] = rnd.Next(1,100);
    }
    return result;
}

void Print(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

double MaxNumber (double[]array)
{
    double max = array[0];
	for (int i = 0; i < array.Length; i++)
	{
		if (max < array[i])
		{
			max = array[i];
		}
	}
	return max;
}
double MinNumber (double[]array)
{
    double min = array[0];
	for (int i = 0; i < array.Length; i++)
	{
		if (min > array[i])
		{
			min = array[i];
		}
	}
	return min;
}
double[] array = InitArray();
Print(array);
double maxNum = MaxNumber(array);
double minNum = MinNumber(array);
double res = maxNum-minNum;
Console.WriteLine($"Разница между максимальным элементом {maxNum} и минимальным {minNum} равна {res}");
