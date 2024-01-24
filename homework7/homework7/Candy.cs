public class Candy : Sweet
{
    public string Flavor { get; private set; }

    // Конструктор для инициализации названия, веса и вкуса конфеты
    public Candy(string name, double weight, string flavor)
        : base(name, weight)
    {
        Flavor = flavor;
    }

    // Метод для получения вкуса конфеты
    public string GetFlavor()
    {
        return Flavor;
    }
}