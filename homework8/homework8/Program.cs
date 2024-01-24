using System;

class Program
{
    static void Main()
    {
        
        LeafyVegetable lettuce = new LeafyVegetable("Lettuce", 150, 5);
        RootVegetable carrot = new RootVegetable("Carrot", 100, 25);
        LeafyVegetable spinach = new LeafyVegetable("Spinach", 120, 7);

       
        Salad salad = new Salad(new IVegetable[] { lettuce, carrot, spinach });

        
        double totalCalories = salad.CalculateTotalCalories();
        Console.WriteLine($"Total calories in the salad: {totalCalories} kcal");

        
        salad.SortVegetablesByWeight();

        
        IVegetable[] vegetablesInRange = SaladSearchExtension.FindVegetablesByCaloriesRange(salad, 5, 20);

       
        Console.WriteLine("Vegetables in the specified calorie range:");
        for (int i = 0; i < vegetablesInRange.Length; i++)
        {
            Console.WriteLine($"{vegetablesInRange[i].GetName()} - {vegetablesInRange[i].GetCaloriesPer100g()} kcal per 100g");
        }
    }
}