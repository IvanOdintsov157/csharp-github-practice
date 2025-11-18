using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        
        public static double Divide(double a, double b)
        {
            // Намеренная ошибка: нет проверки деления на ноль
            return a / b;
        }
        
        // Отсутствует функция возведения в степень
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор C#");
            
            // Тестирование функций
            Console.WriteLine($"5 + 3 = {Calculator.Add(5, 3)}");
            Console.WriteLine($"10 / 0 = {Calculator.Divide(10, 0)}"); // Вызовет исключение
        }
    }
}
