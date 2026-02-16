using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            string command = tokens[0];

            switch (command)
            {
                case "ins":
                    int index = int.Parse(tokens[1]);
                    int element = int.Parse(tokens[2]);
                    if (index >= 0 && index <= numbers.Count)
                        numbers.Insert(index, element);
                    break;

                case "del":
                    int elementToDelete = int.Parse(tokens[1]);
                    numbers.Remove(elementToDelete);
                    break;

                case "contains":
                    int elementToCheck = int.Parse(tokens[1]);
                    Console.WriteLine(numbers.Contains(elementToCheck) ? "YES" : "NO");
                    break;

                case "remove":
                    int removeIndex = int.Parse(tokens[1]);
                    if (removeIndex >= 0 && removeIndex < numbers.Count)
                        numbers.RemoveAt(removeIndex);
                    break;

                case "add":
                    int num1 = int.Parse(tokens[1]);
                    int num2 = int.Parse(tokens[2]);
                    numbers.Add(num1 + num2);
                    break;

                case "large":
                    int number = int.Parse(tokens[1]);
                    foreach (var num in numbers.Where(n => n > number))
                        Console.Write(num + " ");
                    Console.WriteLine();
                    break;

                case "countl":
                    int countNumber = int.Parse(tokens[1]);
                    Console.WriteLine(numbers.Count(n => n > countNumber));
                    break;

                case "cut":
                    int cutNumber = int.Parse(tokens[1]);
                    if (cutNumber >= numbers.Count)
                        numbers.Clear();
                    else
                        numbers.RemoveRange(0, cutNumber);
                    break;

                case "print":
                    Console.WriteLine(string.Join(" ", numbers));
                    break;

                case "end":
                    return;
            }
        }
    }
}
