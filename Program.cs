// See https://aka.ms/new-console-template for more information
using CalcExample;
Calc calc = new Calc();
//public delegate void CalcDel(double num1, double num2);
//CalcDel del = new CalcDel(calc.Add);
Console.WriteLine("Add Call");
calc.Add(12, 45);
Console.WriteLine("Multiply Call");
calc.Multi(10.5, 12.45);
Console.WriteLine("Division Call");
calc.Div(20,4);
Console.WriteLine("Subtraction Call");
calc.Sub(20, 4);
Console.WriteLine("Average call");
calc.Avg(13.5, 35.5);
