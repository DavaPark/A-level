using System;

class Program
{
    static void Main()
    {
        Sweet[] sweets = {
            new Chocolate("Молочный шоколад", 100, 30),
            new Chocolate("Темный шоколад", 80, 70),
            new Candy("Ириска", 50, "Карамель"),
            new Candy("Желе", 30, "Фрукт")
        };

        double totalWeight = 0;

        // Используем цикл for для подсчета общего веса сладостей в подарке
        for (int i = 0; i < sweets.Length; i++)
        {
            totalWeight += sweets[i].GetWeight();
        }

        Console.WriteLine($"Общий вес подарка: {totalWeight} грамм");

        // Сортируем сладости на основе одного из параметров (например, процент какао)
        Array.Sort(sweets, (x, y) =>
        {
            if (x is Chocolate && y is Chocolate)
            {
                return ((Chocolate)x).GetCocoaPercentage().CompareTo(((Chocolate)y).GetCocoaPercentage());
            }
            return 0;
        });

        // Ищем конфету в подарке, соответствующую заданным критериям (например, вкус)
        Candy foundCandy = sweets.OfType<Candy>().FirstOrDefault(c => c.GetFlavor() == "Фрукт");

        if (foundCandy != null)
        {
            Console.WriteLine($"Найдена конфета с вкусом 'Фрукт': {foundCandy.Name}");
        }
        else
        {
            Console.WriteLine("Конфета с вкусом 'Фрукт' не найдена");
        }
    }
}