using System;
using System.Collections.Generic;

namespace Lab1
{
    public class TaskSolver
    {
        public double SolveTask1(double x, double y)
        {

            double numerator = 3 + Math.Exp(y - 1);

            double denominator = 1 + (x * x) * Math.Abs(y - Math.Tan(x));

            if (denominator == 0)
            {
                throw new DivideByZeroException("Знаменник дорівнює нулю.");
            }

            return numerator / denominator;
        }

        public string SolveTask2(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return "Трикутник з такими сторонами не існує!";
            }

            double radA = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
            double radB = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
            double radC = Math.PI - radA - radB;

            double degA = radA * 180 / Math.PI;
            double degB = radB * 180 / Math.PI;
            double degC = radC * 180 / Math.PI;

            return $"Кут A: {radA:F3} рад ({degA:F1}°)\r\n" +
                   $"Кут B: {radB:F3} рад ({degB:F1}°)\r\n" +
                   $"Кут C: {radC:F3} рад ({degC:F1}°)";
        }

        public bool SolveTask3(int n)
        {
            bool isEven = (n % 2 == 0);

            bool isTwoDigit = (Math.Abs(n) >= 10 && Math.Abs(n) <= 99);

            return isEven && isTwoDigit;
        }

        public string SolveTask4(double cost, double moneyGiven)
        {
            if (moneyGiven == cost)
            {
                return "Дякую!";
            }
            else if (moneyGiven > cost)
            {
                double change = moneyGiven - cost;
                return $"Візьміть решту: {change:F2} грн";
            }
            else
            {
                double missing = cost - moneyGiven;
                return $"Недостатньо коштів! Треба ще: {missing:F2} грн";
            }
        }

        public string SolveTask5(int n)
        {
            string result = "";

            for (int number = 1; number < n; number++)
            {
                int sumOfDivisors = 0;

                for (int i = 1; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        sumOfDivisors += i;
                    }
                }

                if (sumOfDivisors == number)
                {
                    result += number + " "; // Додаємо число до рядка
                }
            }

            if (result == "")
            {
                return "Досконалих чисел не знайдено";
            }

            return result;
        }

        public string SolveTask6(string input, int k)
        {
            string[] parts = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> resultList = new List<int>();

            foreach (string part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    if (Math.Abs(number) % 10 == k)
                    {
                        resultList.Add(number);
                    }
                }
            }

            if (resultList.Count == 0)
            {
                return "Чисел не знайдено";
            }

            return string.Join(" ", resultList);
        }

        public string SolveTask7(string text)
        {
            char[] separators = new char[] { ' ', '.', ',', '!', '?', ';', ':', '-', '\n', '\r', '\t' };

            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                return "Слів не знайдено.";
            }

            int minLength = words[0].Length;
            int maxLength = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length < minLength) minLength = word.Length;
                if (word.Length > maxLength) maxLength = word.Length;
            }

            return $"Найкоротше: {minLength} симв.\nНайдовше: {maxLength} симв.";
        }
    }
}