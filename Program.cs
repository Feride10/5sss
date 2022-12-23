// 36
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}



// 38
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (10 + 10) - 10, 2);
}
double MinArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
    }

double MaxArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}
Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(MaxArray(array) - MinArray(array));

