using System;

class Program{

    static void Main(){
      int[] numbers = {10, 20, 30, 80, 90, 1, 3, 45};
      int sumForLoop = 0;
      int sumWhileLoop = 0;
      int sumRecursion = 0;
      int index = 0;
      for(int i = 0; i < numbers.Length; i++){
          sumForLoop+=numbers[i];
      }
      while(index<numbers.Length){
          sumWhileLoop+=numbers[index];
          index++;
      }
      Console.WriteLine($"Sum for loop: {sumForLoop}, Sum while loop: {sumWhileLoop}, Sum recursion: {sumRecursion}");
    }
}

