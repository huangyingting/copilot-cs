using System;
using CopilotCsharp.Library;

namespace CopilotCsharp.App;

public class App
{
    public static void Main(string[] args)
    {        
        int[] bubble_values = { 5, 2, 8, 3, 1, 6 };

        // Print values in one line
        Console.WriteLine("Before bubble sort: " + string.Join(" ", bubble_values));

        // Bubble sort values by using Sort.BubbleSort
        Sort.BubbleSort(bubble_values);

        // Print values in one line
        Console.WriteLine("After bubble sort: " + string.Join(" ", bubble_values));

        // int[] quick_values = { 5, 2, 8, 3, 1, 6, 9, 22 };
        // Print values in one line
        // Quick sort values by using Sort.QuickSort
        // Print values in one line
    }
}
