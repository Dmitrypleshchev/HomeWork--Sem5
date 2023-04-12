/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */ 

int [] CreateArray(int Length)
{

  int[] numbers = new int [Length];
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = new Random().Next(99,999);
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

void Task(int[] numbers)
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if(numbers[i] % 2 == 0) 
    {
      count++;
    }
  }
  Console.WriteLine($" Количество четных чисел в массиве равно {count}");
}

