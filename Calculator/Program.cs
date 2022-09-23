using System;
namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;//обьявление переменной; значение по умолчанию - "не число", которое мы используем, если операция, такая как деление, может привести к ошибке
            switch (op)//условный оператор, оценивает некоторое выражение и сравнивает его значение с набором значений
            {
                case "a"://условный оператор, если значение вводимых данных равно "а"
                    result = num1 + num2;//присвоение результата, выполнение операции сложения
                    break;//завершение выполнение блока команд
                case "s"://условный оператор, если значение вводимых данных равно "s"
                    result = num1 - num2;//присвоение результата, выполнение операции вычитания
                    break;//завершение выполнение блока команд
                case "m"://условный оператор, если значение вводимых данных равно "m"
                    result = num1 * num2;//присвоение результата, выполнение операции умножения
                    break;//завершение выполнение блока команд
                case "d"://условный оператор, если значение вводимых данных равно "d"
                    if (num2 != 0)//условный оператор, выполняется если значение num2 равно "0"
                    {
                        result = num1 / num2;//присвоение результата, выполнение операции деления
                    }
                    break;//завершение выполнение блока команд
                default://условный оператор, возвращаемый текст для неправильного ввода параметра
                    break;//завершение выполнение блока команд
            }
            return result;//условный оператор, завершает выполнение метода и возвращает управление и результат функции вызывавшему методу
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;//обьявление переменной, присвоение значения "false"
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            while (!endApp)//условный оператор, выполняется пока переменная endApp равно значению false
            {
                string numInput1 = "";//обьявление переменной, установливается пустое значение
                string numInput2 = "";//обьявление переменной, установливается пустое значение
                double result = 0;//обьявление переменной, присвоение значения "0"
                //информируем пользователя о требуемом действии
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();//считывание строки из консоли, присвоение результата в переменную numInput1
                double cleanNum1 = 0;//обьявление переменной, присвоение значения "0"
                while (!double.TryParse(numInput1, out cleanNum1))//условный оператор, выполняется пока переменная numInput1 равна "0"
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();//считывание строки из консоли, присвоение результата в переменную numInput1
                }
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();//считывание строки из консоли, присвоение результата в переменную numInput2
                double cleanNum2 = 0;//обьявление переменной, присвоение значения "0"
                while (!double.TryParse(numInput2, out cleanNum2))//условный оператор, выполняется пока переменная numInput2 равна "0"
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();//считывание строки из консоли, присвоение результата в переменную numInput2
                }
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");
                string op = Console.ReadLine();//обьявление переменной, считывание строки из консоли
                try//условный оператор, проверка кода на исключения
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);//присвоение перемееной значения, которое получиться в следствии выполнения операции
                    if (double.IsNaN(result))//условный оператор, выполняется если укузанное значение не является числом (NaN)
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);//условный оператор, вывод на экран значения result
                }
                catch (Exception e)//условный оператор, обработка возможных исключений
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }
                Console.WriteLine("------------------------\n");
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;//условный оператор, при выполнении условия переменная  endApp принимает значение "true"
                Console.WriteLine("\n");//опускает курсор на одну
            }
            return;//условный оператор, завершает выполнение метода
        }
    }
}