using System;
using System.Text;

class Journal
{
    private string publisher;
    private int pageCount;
    private int volume;
    private string author;

    // Властивості для доступу до приватних полів
    public string Title { get; set; }
    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
        }
    }

    // Автоматичні властивості
    public string Category { get; set; }
    public string Language { get; set; }

    // Властивість тільки для читання — розрахунок вартості сторінки
    public double CostPerPage
    {
        get
        {
            return pageCount > 0 ? Math.Round(Price / pageCount, 2) : 0;
        }
    }

    private double price;

    // Конструктор без параметрів
    public Journal()
    {
        publisher = "Невідоме видавництво";
        pageCount = 100;
        Title = "Без назви";
        volume = 1;
        author = "Анонім";
        Price = 0.0;
        Category = "Загальна";
        Language = "Українська";
    }

    public Journal(string title, string author)
    {
        Title = title;
        this.author = author;
        publisher = "Невідоме видавництво";
        pageCount = 50;
        volume = 1;
        Price = 50.0;
        Category = "Освітній";
        Language = "Українська";
    }

    public Journal(string publisher, int pageCount, string title, int volume, string author, double price)
    {
        this.publisher = publisher;
        this.pageCount = pageCount;
        Title = title;
        this.volume = volume;
        this.author = author;
        Price = price;
        Category = "Науковий";
        Language = "Українська";
    }

    public static Journal InitFromConstructor(string title, string author)
    {
        return new Journal(title, author);
    }

    // Метод з передачею параметра за значенням
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
    }

    // Метод з передачею параметра за посиланням
    public void UpdateTitle(ref string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString()
    {
        return $"Назва: {Title}\nАвтор: {author}\nВидавництво: {publisher}\nКількість сторінок: {pageCount}\nТом: {volume}\nЦіна: {Price} грн\nКатегорія: {Category}\nМова: {Language}\nЦіна за сторінку: {CostPerPage} грн\n-----------------------------";
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

        Journal journal1 = new Journal();
        Journal journal2 = new Journal("Методика викладання", "Ковальчук Н.В.");
        Journal journal3 = new Journal("Наукова думка", 120, "Фізика сучасності", 5, "Іваненко О.П.", 85.50);
        Journal journal4 = Journal.InitFromConstructor("Історія України", "Гончаренко С.В.");

        journal1.UpdatePrice(99.99);

        string newTitle = "Оновлена назва";
        journal2.UpdateTitle(ref newTitle);

        Console.WriteLine("Інформація про журнали:");
        journal1.DisplayInfo();
        journal2.DisplayInfo();
        journal3.DisplayInfo();
        journal4.DisplayInfo();
    }
}