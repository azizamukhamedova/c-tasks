using System;

class Program{
    static void Main(){
      int[] numbers = {10, 20, 30, 80, 90, 1, 3, 45, 60};
      int largestNumber = numbers[0];
      for(int i = 0; i < numbers.Length; i++){
        if(largestNumber<numbers[i]){
          largestNumber = numbers[i];
        }
      }
      Console.WriteLine($"The largest number in array is: {largestNumber}");  
    }
}