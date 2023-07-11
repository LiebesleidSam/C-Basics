using Classes;

Calculator calc = new Calculator("decimal");
Console.WriteLine(calc.Add(3.14, 4.2));

namespace Classes
{
    class Calculator
    {
        public string AnswerType {get; set;}
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public Calculator(string type)
        {
            this.AnswerType = type;
        }
    }
}