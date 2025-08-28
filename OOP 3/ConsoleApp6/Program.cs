using System;
using System.Text;

class Journal
{
    private string publisher;
    private int pageCount;
    private string title;
    private int volume;
    private string author;
    private double price;

    // Конструктор без параметрів
    public Journal()
    {
        publisher = "Невідоме видавництво";
        pageCount = 100;
        title = "Без назви";
        volume = 1;
        author = "Анонім";
        price = 0.0;
    }

    // Конструктор з частковим набором параметрів
    public Journal(string title, string author)
    {
        this.title = title;
        this.author = author;
        publisher = "Невідоме видавництво";
        pageCount = 50;
        volume = 1;
        price = 50.0;
    }

    // Конструктор з повним набором параметрів
    public Journal(string publisher, int pageCount, string title, int volume, string author, double price)
    {
        this.publisher = publisher;
        this.pageCount = pageCount;
        this.title = title;
        this.volume = volume;
        this.author = author;
        this.price = price;
    }

    public static Journal InitFromConstructor(string title, string author)
    {
        return new Journal(title, author);
    }

    // Метод ToString()
    public override string ToString()
    {
        return $"Назва: {title}\nАвтор: {author}\nВидавництво: {publisher}\nКількість сторінок: {pageCount}\nТом: {volume}\nЦіна: {price} грн\n-----------------------------";
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

        // Створення об'єктів через різні конструктори
        Journal journal1 = new Journal(); // без параметрів
        Journal journal2 = new Journal("Методика викладання", "Ковальчук Н.В."); // частковий
        Journal journal3 = new Journal("Наукова думка", 120, "Фізика сучасності", 5, "Іваненко О.П.", 85.50); // повний

        // Створення через метод InitFromConstructor
        Journal journal4 = Journal.InitFromConstructor("Історія України", "Гончаренко С.В.");

        // Виведення інформації
        Console.WriteLine("Інформація про журнали:");
        journal1.DisplayInfo();
        journal2.DisplayInfo();
        journal3.DisplayInfo();
        journal4.DisplayInfo();
    }
}
