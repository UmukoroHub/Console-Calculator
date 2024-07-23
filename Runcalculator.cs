using System.Xml.XPath;

namespace Calculatorr;

public class Runcalculator
{
  public static void Calculator1()
  {
    Calculator1 calculate = new Calculator1();

    while (true)
    {
      Console.WriteLine("Enter first number (or type 'exit' to quit): ");
      double num1;

      while (!double.TryParse(Console.ReadLine(), out num1))
      {
        Console.WriteLine("Invalid input, kindly enter a number instead");
      }

      Console.WriteLine("Select an operator: Add, Substract, Multiply, Divide or type \'exit\' to quit");
      string input = Console.ReadLine();

      if (input.ToUpper() == "EXIT")
      {
        break;
      }

      Console.WriteLine("Enter second number: ");
      double num2;

      while (!double.TryParse(Console.ReadLine(), out num2))
      {
        Console.WriteLine("Invalid input, kindly enter a number instead");
      }

      try
      {
        double result = 0;
        bool action = true;

        switch (input.ToUpper())
        {
          case "ADD":
            result = calculate.Add(num1, num2);
            Console.WriteLine("Your addition result is = " + result);
            break;

          case "SUBSTRACT":
            result = calculate.Substract(num1, num2);
            Console.WriteLine("Your substraction result is = " + result);
            break;

          case "MULTIPLY":
            result = calculate.Multiply(num1, num2);
            Console.WriteLine("Your multiplication result is = " + result);
            break;

          case "DIVIDE":
            result = calculate.Divide(num1, num2);
            Console.WriteLine("Your division result is = " + result);
            break;
        }
        if (action)
        {
          Console.WriteLine($"Your choosen action returned result = {result}");
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      Console.WriteLine("Do you want to continue or exit? (Type 'continue' to proceed or 'exit' to quit)");
      string choice = Console.ReadLine();

      if (choice.ToUpper() == "EXIT")
      {
        break;
      }
    }


  }


}