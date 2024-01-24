using System;

class Program
{
    static void Main()
    {
      int arraySize = 10;
      int[] arr = new int[arraySize];
      for(int i = 0; i < arraySize; i++)
      {
        arr[i] = i+1;
        Console.Write(arr[i]+" ");
      }
      ReverseArray(arr);
      PrintArray(arr);
     }
    static void  ReverseArray(int[] arr)
    {
      int left = 0;
      int right = arr.Length - 1;
      while(left < right)
      {
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
        left++;
        right--;
      }
    }
    static void PrintArray(int[] arr)
   {
    foreach(int elem in arr)
     {
       Console.Write($"{elem} ");
     }
    }
}