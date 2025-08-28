using System;
using System.Text;

class Journal
{
    public int PageCount;
    public string Title;
    public int Volume;
    public string Author;

    private string Publisher;
    private double Price;

    public Journal(string publisher, int pageCount, string title, int volume, string author, double price)
    {
        Publisher = publisher;
        PageCount = pageCount;
        Title = title;
        Volume = volume;
        Author = author;
        Price = price;
    }

    public void SetPublisher(string publisher)
    {
        Publisher = publisher;
    }

    public string GetPublisher()
    {
        return Publisher;
    }

    public void SetPrice(double price)
    {
        if (price >= 0)
            Price = price;
    }

    public double GetPrice()
    {
        return Price;
    }

    public override string ToString()
    {
        return $"Назва: {Title}\nАвтор: {Author}\nВидавництво: {Publisher}\nКількість сторінок: {PageCount}\nТом: {Volume}\nЦіна: {Price} грн\n-----------------------------";
    }

    public void DisplayInfo()
    {
        Console.WriteLine(ToString());
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Journal journal1 = new Journal("Наукова думка", 120, "Фізика сучасності", 5, "Іваненко О.П.", 85.50);
        Journal journal2 = new Journal("Освіта України", 90, "Методика викладання", 2, "Ковальчук Н.В.", 65.00);

        Console.WriteLine("Інформація про журнали:");
        journal1.DisplayInfo();
        journal2.DisplayInfo();
    }
}
