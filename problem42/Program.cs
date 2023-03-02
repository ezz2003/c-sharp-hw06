// 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

// string ConvertToBin(int num)
// {
// string numStrBin = string.Empty;
// while (num != 0)
// {
// numStrBin = num % 2 + numStrBin;
// num /= 2;
// }
// return numStrBin;
// }

int ConvertToBin(int num)
{
  int multiplier = 1;
  int result = 0;
  while (num > 0)
  {
    result = result + num % 2 * multiplier;
    num = num / 2;
    multiplier *= 10;
  }
  return result;
}


int number = InputInt("Введите число в десятичной системе счисления");
Console.WriteLine($"{number} -> {ConvertToBin(number)}");