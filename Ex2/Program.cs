using System;

class Program
{
    static void Main()
    {
      int arraySize = 10;
      Random rand = new Random();
      int[] array = new int [arraySize];
      for(int i = 0; i < arraySize; i++) 
      {
        array[i] = rand.Next(100, 1000);
      }
      
      foreach(int elem in array)
      {
        Console.Write(elem +" ");
      }
      
      int count = 0;
      foreach(int elem in array)
      {
        if(elem % 2 == 0)
        {
          count++;
        }  
      }
      Console.Write(count);
     }
}
