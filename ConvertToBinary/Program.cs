using System;
using System.Collections.Generic;
using System.Linq;

Kata.AddBinary(5, 5);
public static class Kata
{
    public static string AddBinary(int a, int b)
    {
        //1.Sum the 2 numbers given
        int result = a+b;
        //2.-Create a List of numbers (because i'll use ".Add()")
        List<int> solution = new List<int>(); 
        //3.Create a for that divides the result between 2 each loop 
        for (int i = result; i > 0; i=(i/2))
        {
            //4.If the result is even save the number 0 in the List
            if (i % 2 == 0)
            {
                solution.Add(0);
            }
            //5.If the result is odd save the number 1 in the array
            else
            { 
                solution.Add(1);
            }
        }
        //6.return the List in the reverse way
        List<int> reversedSolution = Enumerable.Reverse(solution).ToList();
        //7.Convert the List to a string
        string stringReversedSolution = string.Join( "", reversedSolution);
        //8.Return the solution
        Console.WriteLine(stringReversedSolution);
        return stringReversedSolution;
    }
}