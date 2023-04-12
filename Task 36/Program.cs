/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int [] CreateArray(int Length)
{

  int[] numbers = new int [Length];
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = new Random().Next(-10,10);
  }
  return numbers;
}

void PrintArray(int [] numbers)
{
  Console.Write("[");
  for (int i = 0; i < numbers.Length-1; i ++)
  {
    Console.Write(numbers[i] + "; ");
  }
  Console.WriteLine(numbers[numbers.Length-1] + "]");
}

int Num(string argument)
{
  Console.WriteLine($"Введите {argument}");
  return int.Parse(Console.ReadLine());
}

int Length = Num(" длину масссива");
int[] numbers = CreateArray(Length);

PrintArray(numbers);

Task(numbers);

int Task(int[] numbers)
{
int sum = 0;
int i = 0;
while (i < numbers.Length)
{
sum = sum + numbers[i];
i = i + 2;
}
return sum;
}

Console.Write($"Cумма элементов массива, стоящих на нечётных позициях: {Task(numbers)}");

