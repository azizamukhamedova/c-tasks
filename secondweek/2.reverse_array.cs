using System;

class Program{
    static void Main(){
      int[] initialArray = {10, 20, 30, 80, 90, 1, 3, 45};
      Console.WriteLine("[{0}]", string.Join(", ", initialArray));
      for(int i = 0; i < initialArray.Length/2; i++){
          int item = initialArray[i];
          initialArray[i] = initialArray[initialArray.Length - 1 - i];
          initialArray[initialArray.Length - 1 - i] = item;
      }
      Console.WriteLine("[{0}]", string.Join(", ", initialArray));
    }
}