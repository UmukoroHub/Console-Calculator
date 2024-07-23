namespace Calculatorr;

public class Calculator1
{
  public double Add(double num1, double num2)
  {
    return num1 + num2;
  }
  public double Substract(double num1, double num2)
  {
     return num1 - num2; 
  }
   
   public double Multiply(double num1, double num2)
   {
    return num1 * num2;
   }
   public double Divide(double num1, double num2)
   {
    if (num1 == 0|| num2 == 0)
    {
      throw new DivideByZeroException("Division by zero is not accepted");  
    }
    return num1 / num2;
   }

}