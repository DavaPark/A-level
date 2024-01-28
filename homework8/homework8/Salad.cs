public class Salad
{
    internal object vegetables;
    private IVegetable[] Vegetables;

    public Salad(IVegetable[] vegetables)
    {
        Vegetables = vegetables;
    }

    public IVegetable[] GetVegetables()
    {
        return Vegetables;
    }

    public double CalculateTotalCalories()
    {
        double totalCalories = 0;
        foreach (var vegetable in Vegetables)
        {
            totalCalories += (vegetable.GetWeight() / 100) * vegetable.GetCaloriesPer100g();
        }
        return totalCalories;
    }

    public void SortVegetablesByWeight()
    {
        
        for (int i = 0; i < Vegetables.Length - 1; i++)
        {
            for (int j = 0; j < Vegetables.Length - 1 - i; j++)
            {
                if (Vegetables[j].GetWeight() > Vegetables[j + 1].GetWeight())
                {
                   
                    var temp = Vegetables[j];
                    Vegetables[j] = Vegetables[j + 1];
                    Vegetables[j + 1] = temp;
                }
            }
        }
  
    }
}