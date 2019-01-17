using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArraysHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            string userString = "";
            Console.WriteLine("Введите строку(поставьте точку когда захотите закончить)");
            while (true)
            {
                char symbol = (char)Console.Read();
                if (symbol == '.')
                {
                    break;
                }
                userString += symbol;
            }

            int amountOfSpaces = 0;
            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] == ' ')
                {
                    amountOfSpaces++;
                }
            }
            Console.WriteLine("Количество пробелов в веденном предложении " + amountOfSpaces);
            Console.WriteLine("Нажмите enter для продолжения");
            Console.ReadLine();
            Console.ReadLine();

            //#2
            Console.Clear();
            Console.WriteLine("Введите номер билета(6 цифр)");
            int ticketNumbersCount = 6;
            int[] ticket = new int[ticketNumbersCount];
            for (int i = 0; i < ticketNumbersCount; i++)
            {
                ticket[i] = Console.Read();
            }
            int sumOfFirstTreeNumbers = ticket[0] + ticket[1] + ticket[2];
            int sumOfLastTreeNumbers = ticket[3] + ticket[4] + ticket[5];

            if (sumOfFirstTreeNumbers == sumOfLastTreeNumbers)
            {
                Console.WriteLine("У вас счастливый билет!");
            }
            else
            {
                Console.WriteLine("У вас обычный билет");
            }
            Console.WriteLine("Нажмите enter для продолжения");
            Console.ReadLine();
            Console.ReadLine();

            //#3
            Console.Clear();
            Console.WriteLine("Введите строку(поставьте точку для конца предложения)");
            string someString = "";
            while (true)
            {
                char symb = (char)Console.Read();
                if (symb == '.')
                {
                    break;
                }
                if ((int)symb >= 65 && (int)symb <= 90)
                {
                    someString += (char)(symb + 32);
                }
                else if ((int)symb >= 97 && (int)symb <= 122)
                {
                    someString += (char)(symb - 32);
                }
            }
            Console.WriteLine("Получившаяся строка - " + someString);
            Console.WriteLine("Нажмите enter для продолжения");
            Console.ReadLine();
            Console.ReadLine();
            //#4
            Console.Clear();

            Console.WriteLine("Введите первое число");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите enter для продолжения");
            Console.ReadLine();

            //#5
            Console.Clear();
            Console.WriteLine("Введите число");
            int userNumber = int.Parse(Console.ReadLine());

            int size = 0;

            for (int i = userNumber; i > 0; i /= 10)
            {
                size++;
            }

            int[] numberArray = new int[size];

            for (int i = userNumber, q = 0; q < numberArray.Length; i /= 10, q++)
            {
                numberArray[q] = i % 10;
            }
            Console.Write("Перевернутое число - ");
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write(numberArray[i]);
            }
            Console.WriteLine("Нажмите enter для выхода");
            Console.ReadLine();
        }
    }
}
