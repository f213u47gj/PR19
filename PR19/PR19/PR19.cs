using System;

namespace PR19 //  имя простртранства 
{
    public class PR19 // создание класса 
    {
        public void ProductionOfOddNumbers() // создаем метод
        {
            int result = 1; // задали перемнную результата
            int sum = 0;
            int proiz = 1;

            for (int i = 11; i < 100; i += 2) // создали цикл  от 13 до 99, где шаг 26
            {
                if (i % 13 == 0) // проверка на кратность 13
                {
                    proiz *= i; // произведение
                    result = i*i; // умножение друг на друга
                    sum += result; // считаем сумму
                    Console.WriteLine($"Произведение {i}*{i}=" + result); // Вывод результата
                }
            }
            Console.WriteLine("Сумма всех произвдений: " + sum ); // Вывод результата
            Console.WriteLine("Произведение чисел: " + proiz); // Вывод результата
        }
    } 
}
    

