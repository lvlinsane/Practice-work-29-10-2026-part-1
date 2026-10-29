Person p1 = new Person("Иванов Иван Иванович", 20, "ivanov@mail.ru");
Person p2 = new Person("Петрова Анна Сергеевна", 35, "petrova@gmail.com");
Person p3 = new Person("Сидоров Test", -5, "test@mail.ru");

Console.WriteLine("\n=== Информация о людях ===");
p1.DisplayInfo();
Console.WriteLine();
p2.DisplayInfo();
Console.WriteLine();
p3.DisplayInfo();
