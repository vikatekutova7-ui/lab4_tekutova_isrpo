using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте");
        string? fio = "Текутова Виктория Денисовна";
        string? group = "ИСП-231";
        string data = DateTime.Now.ToString();
        Console.WriteLine("\nМеню:");
        Console.WriteLine("1 — Показать ФИО");
        Console.WriteLine("2 — Показать группу");
        Console.WriteLine("3 — Показать дату");
        Console.WriteLine("4 — Выход");
        string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.WriteLine("ФИО: Текутова Виктория Денисовна");
                    break;
                case "2":
                    Console.WriteLine("Группа: ИСП-231");
                    break;
                case "3":
                    Console.WriteLine($"Текущая дата и время: {DateTime.Now}");
                    break;
                case "4":
                    Console.WriteLine("Выход из программы. До свидания!");
                    break;
         }
    }
}