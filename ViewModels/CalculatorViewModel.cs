
using System;
using System.Timers;

namespace Workup.ViewModels;

public partial class CalculatorViewModel : BaseViewModel
{
  public static double Calculator(double x, double y, string operation)
    {
        double result = 0;
        switch (operation)
        {
             case "+":
                double sum = x + y;
                result = sum;
            break;
             case "-":
                double difference = x - y;
                result = difference;
            break;
               case "÷":
                double product = x / y;
                result = product;
            break;
            case "×":
                result = x * y;
            break;   
        }
        return result;
    }
}
