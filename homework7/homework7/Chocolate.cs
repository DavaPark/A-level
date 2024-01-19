public class Chocolate : Sweet
{
    public int CocoaPercentage { get; private set; }

    // Конструктор для инициализации названия, веса и процента какао в шоколаде
    public Chocolate(string name, double weight, int cocoaPercentage)
        : base(name, weight)
    {
        CocoaPercentage = cocoaPercentage;
    }

    // Метод для получения процента какао
    public int GetCocoaPercentage()
    {
        return CocoaPercentage;
    }
}