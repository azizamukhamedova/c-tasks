using System;

class Program{
    static void Main(){
      int number = 1;
      int[] numbers = {10, 20, 30, 80, 90, 1, 3, 45};
      for(int i = 0; i < numbers.Length; i++){
          if(number == numbers[i]){
              Console.WriteLine("Number is in array");
              break;
          }
      }
      Console.WriteLine("Array does not contain this number");
    }
}