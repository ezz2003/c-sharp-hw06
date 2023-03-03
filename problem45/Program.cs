// 45.Напишите программу, которая будет создавать копию заданного массива, с помощью поэлементного копирования. 

int[] MakeArrayRnd(int size, int min, int max)
{
  int[] array = new int[size];
  Random rnd = new Random();
  for (int i = 0; i < size; i++) array[i] = rnd.Next(min, max + 1);
  return array;
}

string MakeStringToPrintArray(int[] arr)
{
  string strPrn = string.Empty;
  for (int i = 0; i < arr.Length - 1; i++) strPrn += $"{arr[i]}, ";
  strPrn += arr.Last();
  return $"[ {strPrn} ]";
}

int[] MakeCopyArray(int[] arr)
{
  int[] copyArr = new int[arr.Length];
  for (int i = 0; i < arr.Length; i++) { copyArr[i] = arr[i]; }
  return copyArr;
}

int[] readyArray = MakeArrayRnd(12, -9, 9);
int[] copyReadyArray = MakeCopyArray(readyArray);
Console.WriteLine($" Оригинал - массив  {nameof(readyArray)} - {MakeStringToPrintArray(readyArray)}");
Console.WriteLine($"Копия - массив  {nameof(copyReadyArray)} - {MakeStringToPrintArray(copyReadyArray)}");
