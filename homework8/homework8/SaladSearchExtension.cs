public static class SaladSearchExtension
{
    public static IVegetable[] FindVegetablesByCaloriesRange(Salad salad, double minCalories, double maxCalories)
    {
        IVegetable[] vegetables = salad.GetVegetables();

       
        int count = 0;
        for (int i = 0; i < vegetables.Length; i++)
        {
            if (vegetables[i].GetCaloriesPer100g() >= minCalories && vegetables[i].GetCaloriesPer100g() <= maxCalories)
            {
                count++;
            }
        }

      
        IVegetable[] result = new IVegetable[count];

       
        int index = 0;
        for (int i = 0; i < vegetables.Length; i++)
        {
            var vegetable = vegetables[i];
            if (vegetable.GetCaloriesPer100g() >= minCalories && vegetable.GetCaloriesPer100g() <= maxCalories)
            {
                result[index] = vegetable;
                index++;
            }
        }

        return result;
    }
}