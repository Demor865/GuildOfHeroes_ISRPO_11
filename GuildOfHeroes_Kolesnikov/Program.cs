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

// Начало проверки здоровья
Hero lowProbe = new Hero("Проверка нижней границы", -100);
Hero highProbe = new Hero("Проверка верхней границы", 5000);
Console.WriteLine($"Нижняя граница: {lowProbe.Health}/{lowProbe.MaxHealth}");
Console.WriteLine($"Верхняя граница: {highProbe.Health}/{highProbe.MaxHealth}");
Console.WriteLine($"Александр до действий: {alexander.Health}/{alexander.MaxHealth}");

alexander.TakeDamage(30);
alexander.Heal(10);
Console.WriteLine($"Обычные действия: {alexander.Health}");
alexander.Heal(5000);
Console.WriteLine($"Большое лечение: {alexander.Health}");
alexander.Heal(-20);
Console.WriteLine($"Отказ в лечении: {alexander.Health}");
alexander.TakeDamage(5000);
Console.WriteLine($"Большой урон: {alexander.Health}; жив: {alexander.IsAlive()}");
alexander.Heal(20);
Console.WriteLine($"Восстановление: {alexander.Health}");
Console.WriteLine($"Артём без изменений: {artem.Health}/{artem.MaxHealth}");
// Конец проверки здоровья

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