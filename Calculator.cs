using System;

namespace CalculatorApp
{
    /// <summary>
    [cite_start]/// Предоставляет статические методы для выполнения основных математических операций[cite: 231].
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Выполняет сложение двух чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Сумма двух чисел.</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }
        
        /// <summary>
        /// Выполняет вычитание двух чисел.
        /// </summary>
        /// <param name="a">Уменьшаемое.</param>
        /// <param name="b">Вычитаемое.</param>
        /// <returns>Разность двух чисел.</returns>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        
        /// <summary>
        /// Выполняет умножение двух чисел.
        /// </summary>
        /// <param name="a">Первый множитель.</param>
        /// <param name="b">Второй множитель.</param>
        /// <returns>Произведение двух чисел.</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        
        /// <summary>
        /// Выполняет деление двух чисел. Обрабатывает деление на ноль, возвращая NaN.
        /// </summary>
        /// <param name="a">Делимое.</param>
        /// <param name="b">Делитель.</param>
        /// <returns>Результат деления. [cite_start]Возвращает Double.NaN, если делитель равен нулю[cite: 198].</returns>
        public static double Divide(double a, double b)
        {
            // Исправление Issue #1: Добавлена проверка деления на ноль.
            if (b == 0)
            {
                // Возвращаем Not-a-Number (NaN) для корректной обработки в Main.
                return double.NaN; 
            }
            return a / b;
        }
        
        /// <summary>
        /// Выполняет возведение числа в указанную степень.
        /// </summary>
        /// <param name="base">Основание (число, которое возводят в степень).</param>
        /// <param name="exponent">Показатель степени.</param>
        [cite_start]/// <returns>Результат возведения числа в степень[cite: 209, 211].</returns>
        public static double Power(double @base, double exponent)
        {
            // Реализация Issue #2.
            return Math.Pow(@base, exponent);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор C#");
            
            // Тестирование функции сложения
            Console.WriteLine($"5 + 3 = {Calculator.Add(5, 3)}");

            // Тестирование деления с обработкой исключений (Issue #1 Fix)
            try
            {
                double result = Calculator.Divide(10, 0);
                if (double.IsNaN(result))
                {
                     // Вывод сообщения об ошибке, как требовалось в Issue #1.
                     [cite_start]Console.WriteLine($"10 / 0 = Деление на ноль невозможно[cite: 198].");
                }
                else
                {
                    Console.WriteLine($"10 / 0 = {result}");
                }
            }
            catch (Exception ex)
            {
                // Блок для обработки непредвиденных исключений.
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
            
            // Тестирование новой функции возведения в степень (Issue #2)
            Console.WriteLine($"2 в степени 4 = {Calculator.Power(2, 4)}");
            Console.WriteLine($"3 в степени 3 = {Calculator.Power(3, 3)}");
        }
    }
}
