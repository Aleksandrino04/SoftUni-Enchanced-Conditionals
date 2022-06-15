using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        



            static void Main(string[] args)
            {
                double num1 = int.Parse(Console.ReadLine());
                double num2 = int.Parse(Console.ReadLine());
                string operation = Console.ReadLine();
                double sum = 0.0;
                if (operation == "+")
                {
                    sum = num1 + num2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} + {num2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} + {num2} = {sum} - odd");
                    }
                }
                else if (operation == "-")
                {
                    sum = num1 - num2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} - {num2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} - {num2} = {sum} - odd");
                    }
                }
                else if (operation == "/")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        sum = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {sum:F2}");
                    }
                }
                else if (operation == "*")
                {
                    sum = num1 * num2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} * {num2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} * {num2} = {sum} - odd");
                    }
                }
                else if (operation == "%")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        sum = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {sum}");
                    }
                }
            }
        }
    }










   
