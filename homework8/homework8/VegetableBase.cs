public abstract class VegetableBase : IVegetable
{
    protected string Name;
    protected double Weight;
    protected double CaloriesPer100g;

    protected VegetableBase(string name, double weight, double caloriesPer100g)
    {
        Name = name;
        Weight = weight;
        CaloriesPer100g = caloriesPer100g;
    }

    public string GetName()
    {
        return Name;
    }

    public double GetWeight()
    {
        return Weight;
    }

    public double GetCaloriesPer100g()
    {
        return CaloriesPer100g;
    }
}