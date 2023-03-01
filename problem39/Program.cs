// 39. напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, первый - на последнем, и т.д.)
// 
// [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]


string MakeStrPrintArr(int[] arr)
{
  string strPrn = string.Empty;
  for (int i = 0; i < arr.Length - 1; i++) strPrn += $"{arr[i]}, ";
  strPrn += arr.Last();
  return strPrn;
}

void SwapArray(int[] arr)
{
  for (int i = 0; i < arr.Length / 2; i++) (arr[i], arr[arr.Length - i - 1]) = (arr[arr.Length - i - 1], arr[i]);
}


int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
Console.Write($"[{MakeStrPrintArr(array)}] -> ");
SwapArray(array);
Console.WriteLine($"[{MakeStrPrintArr(array)}]");
