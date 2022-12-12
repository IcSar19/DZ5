Console.Clear();
Console.Write ("Введите число элементов массива: ");

int a = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [a];
int amount = 0;

GetArray (numbers);
PrintArray (numbers);

for (int i = 0; i < a; i++)
{
  if (numbers[i] % 2 == 0)
  {
    amount++;
  }
}

Console.WriteLine ($"количество чётных чисел в массиве: {amount}");

void GetArray (int [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    numbers [i] = new Random().Next(0,1000);
  }
}

void PrintArray (int [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write ($"{numbers [i]} ");
  }
  
  Console.WriteLine();
}