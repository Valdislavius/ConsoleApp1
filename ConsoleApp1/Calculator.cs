namespace ConsoleApp1;

class Calculator
{
    public double num1;
    public double num2;
    public string operation;

    public double Calculate()
    {
        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                if (num2 == 0) throw new DivideByZeroException("Делить на 0 нельзя");
                result = num1 / num2;
                break;
            default:
                throw new InvalidOperationException("Неверная операция");
        }
        return result;
    }

}

