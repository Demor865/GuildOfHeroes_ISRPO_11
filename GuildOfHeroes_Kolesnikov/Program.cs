// Герои
using System.Diagnostics;

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);

Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());

// Оружия
Console.WriteLine("\n    >>> Класс оружия <<<\n");
Weapon Sword = new Weapon("Эскалибур", 46, "Меч");
Weapon Bow = new Weapon("Охотничий лук", 5, "Лук");
Weapon Staff = new Weapon("Жезл молний", 34, "Посох");

Console.WriteLine(Sword.GetInfo()); // Получение информации о оружии
Bow.Strength_Damage(1.5); // Снижение прочности с параметром и переполнением лимита
Console.WriteLine($"Лук поломан: {Bow.IsBroken()}");
Staff.Strength_Damage(); // Снижение прочности без параметра
Bow.Strength_Heal(0.12); // Починка
Console.WriteLine($"Лук поломан: {Bow.IsBroken()}");
Sword.Strength_Heal(0.4); // Попытка починить целый предмет
Sword.Rename("Легендарный меч"); // Смена имени

Console.WriteLine();
Console.WriteLine(Sword.GetInfo());
Console.WriteLine();
Console.WriteLine(Bow.GetInfo());
Console.WriteLine();
Console.WriteLine(Staff.GetInfo());