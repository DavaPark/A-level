public class RootVegetable : VegetableBase
{
    private string RootType;

    public RootVegetable(string name, double weight, double caloriesPer100g) : base(name, weight, caloriesPer100g)
    {
    }

    public string GetRootType()
    {
        return RootType;
    }

}