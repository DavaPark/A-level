public class LeafyVegetable : VegetableBase
{
    private bool IsIronRich;

    public LeafyVegetable(string name, double weight, double caloriesPer100g)
        : base(name, weight, caloriesPer100g)
    {
    }

    public bool GetIsIronRich()
    {
        return IsIronRich;
    }
}