// using System.CodeDom.Compiler;
// using System.Collections.Generic;
// using System.Collections;
// using System.ComponentModel;
// using System.Diagnostics.CodeAnalysis;
// using System.Globalization;
// using System.IO;
// using System.Linq;
// using System.Reflection;
// using System.Runtime.Serialization;
// using System.Text.RegularExpressions;
// using System.Text;
// using System;

// class Result
// {

//     /*
//      * Complete the 'countingSort' function below.
//      *
//      * The function is expected to return an INTEGER_ARRAY.
//      * The function accepts INTEGER_ARRAY arr as parameter.
//      */

//     public static List<int> countingSort(List<int> arr)
//     {
//         // create zero array to count frequency
//         var zeroFrequencyArray = new List<int>();
//         for (int i = 0; i < 100; i++)
//         {
//             zeroFrequencyArray.Add(0);
//         }

//         foreach (int value in arr)
//         {
//             // get the position and increment
//             var t = zeroFrequencyArray[value];
//             t++;
//             zeroFrequencyArray[value] = t;
//         }

//         return zeroFrequencyArray;

//         // create sorted list and populate occurences
//         // var sortedList = new List<int>();
//         // for (int i = 0; i < zeroArray.Count; i++)
//         // {
//         //     for (int j = 0; j < zeroArray[i]; j++)
//         //     {
//         //            sortedList.Add(i); 
//         //     }
//         // }

//         // return sortedList;
//     }
// }

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         //int n = Convert.ToInt32(Console.ReadLine().Trim());
//         int n = 100;

// string input = "63 25 73 1 98 73 56 84 86 57 16 83 8 25 81 56 9 53 98 67 99 12 83 89 80 91 39 86 76 85 74 39 25 90 59 10 94 32 44 3 89 30 27 79 46 96 27 32 18 21 92 69 81 40 40 34 68 78 24 87 42 69 23 41 78 22 6 90 99 89 50 30 20 1 43 3 70 95 33 46 44 9 69 48 33 60 65 16 82 67 61 32 21 79 75 75 13 87 70 33";
// string input2 = "63 54 17 78 43 70 32 97 16 94 74 18 60 61 35 83 13 56 75 52 70 12 24 37 17 0 16 64 34 81 82 24 69 2 30 61 83 37 97 16 70 53 0 61 12 17 97 67 33 30 49 70 11 40 67 94 84 60 35 58 19 81 16 14 68 46 42 81 75 87 13 84 33 34 14 96 7 59 17 98 79 47 71 75 8 27 73 66 64 12 29 35 80 78 80 6 5 24 49 82";
//          List<int> arr = input2.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//         //List<int> arr = new List<int> { 1, 1, 3, 2, 1 };

//         List<int> result = Result.countingSort(arr);

//         Console.WriteLine(string.Join(" ", result));

//         //    textWriter.WriteLine(String.Join(" ", result));

//         // textWriter.Flush();
//         // textWriter.Close();
//     }
// }
