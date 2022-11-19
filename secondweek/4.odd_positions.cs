using System;

class Program{
    static void Main(){
      int[] numbers = {10, 20, 30, 80, 90, 1, 3, 45};
      for(int i = 1; i <= numbers.Length; i++){
          if(i%2!=0){
              Console.WriteLine($"Number in odd position {numbers[i-1]}");
          }
      }
    }
}