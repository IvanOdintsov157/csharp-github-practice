using System;

namespace CalculatorApp
{
    /// <summary>
    /// Предоставляет статические методы для выполнения основных математических операций.
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
        /// <returns>Результат деления. Возвращает Double.NaN, если делитель равен нулю.</returns>
        public static double Divide(double a, double b)
        {
            // Исправление Issue #1: Добавлена проверка деления на ноль
            if (b == 0)
            {
                // Для double деление на 0 обычно дает Infinity, но мы можем явно вернуть NaN 
                // или бросить исключение, если того требует логика. 
                // Здесь возвращаем NaN, чтобы избежать падения программы.
                return double.NaN; 
            }
            return a / b;
        }
        
         // Отсутствует функция возведения в степень (Feature Issue #2)
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор C#");
            
            // Тестирование функций
            Console.WriteLine($"5 + 3 = {Calculator.Add(5, 3)}");

            // Обработка потенциальных ошибок (для Divide)
            try
            {
                double result = Calculator.Divide(10, 0);
                if (double.IsNaN(result))
                {
                     Console.WriteLine($"10 / 0 = Деление на ноль невозможно.");
                }
                else
                {
                    Console.WriteLine($"10 / 0 = {result}");
                }
            }
            catch (Exception ex)
            {
                // Общий блок обработки исключений, если бы метод Divide бросал исключение.
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
