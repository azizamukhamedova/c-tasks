// using System;

// class Program{
//     bool isPalindrome(string input){
//         for(int i = 0; i < input.Length/2; i++){
//           if(input[i] != input[input.Length - 1 - i]){
//             return false;
//           }
//         }
//         return true;
//     }
//     static void Main(){
//       string word = "hello";
//       string second = "aba";
//       for(int i = 0; i < word.Length/2; i++){
//           if(word[i] == word[word.Length - 1 - i]){
//             Console.WriteLine($"true {i} {word}");
//           }
//         }
//         for(int i = 0; i < second.Length/2; i++){
//           if(second[i] == second[second.Length - 1 - i]){
//             Console.WriteLine($"true {i} ${second}");
//           }
//         }
//     //   bool value = isPalindrome(input: "hello");
//     //   Console.WriteLine($"String is palindrom {word}: {value}");
//     // //   Console.WriteLine($"String is palindrom {second}: {isPalindrome(second)}");
//     }
// }