// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine ("Ввод чисел:");
string numbers = Console.ReadLine();
string [] newNumbers = new string [numbers.Length];
int M = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
  if (numbers[i] == ',')
  {
    M++;
  }
  else
  {
    newNumbers[M] = newNumbers[M]+$"{numbers[i]}";
  }
}
M++;
int [] resultNumbers = new int[M];
PrintArray (resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < M; i++)
{
  if (resultNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Чисел больше 0 ввёл пользователь: "+sum);

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}