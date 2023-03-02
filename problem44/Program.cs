// 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые 2 числа Фибоначчи: 0 и 1.

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

string GetSeriesFibonacci(int num)
{
  if (num <= 0) return "ряд Фибоначчи не существует";
  if (num == 1) return "1";
  int f1 = 0;
  int f2 = 1;
  int fTmp = 0;
  string series = f1 + " " + f2;
  for (int i = 0; i < num - 2; i++)
  {
    fTmp = f1 + f2;
    f1 = f2;
    f2 = fTmp;
    series = series + " " + f2;
  }
  return series;
}

int number = InputInt("Введите чило N для вывода ряда Фибоначчи");
Console.WriteLine($"Если N = {number} -> {GetSeriesFibonacci(number)}");