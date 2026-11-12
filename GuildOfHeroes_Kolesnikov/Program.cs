// Герои
using System.Diagnostics;

Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");

// Оружия
Console.WriteLine("\n    >>> Класс оружия <<<\n");
Weapon Sword = new Weapon("Эскалибур", 46, "Меч");
Weapon Bow = new Weapon("Охотничий лук", 5, "Лук");
Weapon Staff = new Weapon("Жезл молний", 34, "Посох");



Console.WriteLine();
Console.WriteLine(Sword.GetInfo());
Console.WriteLine();
Console.WriteLine(Bow.GetInfo());
Console.WriteLine();
Console.WriteLine(Staff.GetInfo());