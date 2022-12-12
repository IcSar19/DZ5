Console.Clear();
Console.Write ("Введите число элементов массива: ");

int a = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double [a];
double max = numbers [0];

FillArray (numbers);
PrintArray (numbers);

for (int i = 0; i < a; i++)
{
  if (numbers[i] > max)
  {
    max = numbers[i];
  }
}
double min = numbers [0];

for (int i = 0; i < a; i++)
{
  if (numbers[i] < min)
  {
    min = numbers[i];
  }
}
double difference = max - min;
Console.WriteLine ($"Разница между макс и мин элементами массива: {difference}");

void FillArray (double [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    numbers [i] = new Random().Next(0,100);
  }

}

void PrintArray (double [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write ($"{numbers [i]} ");
  }

  Console.WriteLine();
}