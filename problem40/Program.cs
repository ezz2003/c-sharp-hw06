// 40. Напишите программуб которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

string CheckTriangle(int a, int b, int c)
{
  if ((a + b > c) & (a + c > b) & (b + c > a)) return "";
  else return "не";
}


int sideA = InputInt("Введите длину строны А");
int sideB = InputInt("Введите длину строны B");
int sideC = InputInt("Введите длину строны C");
Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} {CheckTriangle(sideA, sideB, sideC)} существует");
