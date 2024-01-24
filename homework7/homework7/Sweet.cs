public class Sweet
{
    public string Name { get; private set; }
    public double Weight { get; private set; }

    // Конструктор для инициализации названия и веса сладости
    public Sweet(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    // Метод для получения веса сладости
    public double GetWeight()
    {
        return Weight;
    }
}