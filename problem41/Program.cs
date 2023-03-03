// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 
// 0, 7, 8, -2, -2 -> 2
// 
// 1, -7, 567, 89, 223-> 3

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

string MakeStringToPrintArray(int[] arr)
{
  string strPrn = string.Empty;
  for (int i = 0; i < arr.Length - 1; i++) strPrn += $"{arr[i]}, ";
  strPrn += arr.Last();
  return $"{strPrn}";
}


int[] InputAnyNumbers(int quantity)
{
  int[] usersArray = new int[quantity];
  for (int i = 0; i < quantity; i++)
  {
    usersArray[i] = InputInt($"Введите {i + 1} число");
  }
  return usersArray;
}

int HowManyGreaterZero(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0) { count++; }
  }
  return count;
}

int quantityM = InputInt("Сколько чисел будете вводить?");
int[] usersNumbers = InputAnyNumbers(quantityM);
Console.WriteLine($"{MakeStringToPrintArray(usersNumbers)} -> {HowManyGreaterZero(usersNumbers)}");
