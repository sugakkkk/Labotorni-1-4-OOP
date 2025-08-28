
using System;
using System.Text;

class Journal
{

    public string Publisher;
    public int PageCount;
    public string Title;
    public int Volume;
    public string Author;
    public double Price;


    public Journal(string publisher, int pageCount, string title, int volume, string author, double price)
    {
        Publisher = publisher;
        PageCount = pageCount;
        Title = title;
        Volume = volume;
        Author = author;
        Price = price;
    }


    public void DisplayInfo()
    {
        Console.WriteLine("Назва: " + Title);
        Console.WriteLine("Автор: " + Author);
        Console.WriteLine("Видавництво: " + Publisher);
        Console.WriteLine("Кількість сторінок: " + PageCount);
        Console.WriteLine("Том: " + Volume);
        Console.WriteLine("Ціна: " + Price + " грн");
        Console.WriteLine("-----------------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Journal journal1 = new Journal("Наукова думка", 120, "Фізика сучасності", 5, "Іваненко О.П.", 85.50);
        Journal journal2 = new Journal("Освіта України", 90, "Методика викладання", 2, "Ковальчук Н.В.", 65.00);
        Console.WriteLine("Інформація про журнали:");
        Console.WriteLine("-----------------------------");
        journal1.DisplayInfo();
        journal2.DisplayInfo();
    }
}
