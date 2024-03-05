namespace Homework15;

class Program
{
    delegate decimal CalculateDelegate(decimal a, decimal b);

    static void Main(string[] args)
    {
        CalculateDelegate calculateDelegate = CalculateSum;

        calculateDelegate += CalculateSum;

        CalculateSumWithWrapper(calculateDelegate);

    }

    static decimal CalculateSum(decimal a, decimal b)
    {
        return a + b;
    }
    
    static void CalculateSumWithWrapper(CalculateDelegate calculateDelegate)
    {
        try
        {
            decimal result = calculateDelegate(34, 23);
            Console.WriteLine("Result solution = " + result);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error" + ex.Message);
        }
    }
}

