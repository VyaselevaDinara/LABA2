using System;

public class Program
{
    // Перечисление для дней недели
    public enum Weekday
    {
        // Увеличиваем значение для первого дня недели
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    // Перечисление для времени суток
    public enum Time
    {
        Morning,
        Day,
        Evening,
        Night
    }

    public static void Main()
    {
        Weekday day;
        int time;

        // Запрашиваем у пользователя день недели с корректными значениями
        Console.Write("Введите день недели (1-7): ");
        int inputDay = int.Parse(Console.ReadLine());

        // Проверка на корректность значения дня недели
        if (inputDay < 1 || inputDay > 7)
        {
            Console.WriteLine("Неверный Ввод. День недели должен находиться между 1-7.");
            return;
        }

        day = (Weekday)inputDay;

        // Запрашиваем у пользователя время с корректными значениями
        Console.Write("Введите время суток (0-23): ");
        time = int.Parse(Console.ReadLine());

        // Проверка на корректность значения времени
        if (time < 0 || time > 23)
        {
            Console.WriteLine("Неверный Ввод. День недели должен находиться между 0-23.");
            return;
        }

        // Получение строкового представления выбранного дня недели с помощью метода GetName класса Enum.
        string dayString = Enum.GetName(typeof(Weekday), day);

        Time timeOfDay;
        // Определяем время суток на основе введенного времени
        if (time >= 7 && time <= 12)
        {
            timeOfDay = Time.Morning;
        }
        else if (time >= 13 && time <= 18)
        {
            timeOfDay = Time.Day;
        }
        else if (time >= 18 && time <= 23)
        {
            timeOfDay = Time.Evening;
        }
        else
        {
            timeOfDay = Time.Night;
        }

        // Получаем строковое представление времени суток
        string timeString = Enum.GetName(typeof(Time), timeOfDay);

        // Выводим сообщение о текущем дне недели и времени суток
        Console.WriteLine($"Сейчас {dayString}, {timeString}");
    }
}