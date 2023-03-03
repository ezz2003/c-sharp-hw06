// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)


int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

double[] IntersectionGraphs(double b1, double k1, double b2, double k2)
{
  double[] xy = new double[2];
  xy[0] = Math.Round(((b2 - b1) / (k1 - k2)), 1);
  xy[1] = Math.Round((k1 * xy[0] + b1), 1);
  return xy;
}



Console.WriteLine("Даны два уравнения:");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите по очереди значения b1, k1, b2 и k2");
double bb1 = InputInt("Введите значение b1");
double kk1 = InputInt("Введите значение k1");
double bb2 = InputInt("Введите значение b2");
double kk2 = InputInt("Введите значение k2");
if (kk1 != kk2)
{
  double[] answerIntersection = IntersectionGraphs(bb1, kk1, bb2, kk2);
  Console.WriteLine($"b1 = {bb1}, k1 = {kk1}, b2 = {bb2}, k2 = {kk2} -> ({answerIntersection[0]}, {answerIntersection[1]})");
}
else
{ Console.WriteLine("Графики параллельны (не пересекутся)"); }


