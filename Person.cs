class Person
{
    public string FullName { get; set; }
    public int Age { get; private set; }
    public string Email { get; set; }

    // конструктор
    public Person(string fullName, int age, string email)
    {
        FullName = fullName;
        Email = email;

        // проверяем возраст
        if (age < 0 || age > 120)
        {
            Console.WriteLine($"Ошибка: возраст {age} неверный. Поставили 0.");
            Age = 0;
        }
        else
        {
            Age = age;
        }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"ФИО: {FullName}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Email: {Email}");
    }
}
