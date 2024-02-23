
namespace Homework14;
public class Class1
{

    public delegate void ShowDelegate(bool value);
  
    public decimal Multiply(decimal x, decimal y)
    {
        return x * y;
    }
}


public class Class2
{
    private decimal result; 

    
    public Func<decimal, bool> Calc(Func<decimal, decimal, decimal> multiplyDelegate, decimal x, decimal y)
    {    
        result = multiplyDelegate(x, y);    
        return (number) =>
        {
            return Result(number);
        };
    }

    private bool Result(decimal number)
    {
        return result % number == 0;
    }
}

class Program
{
    static void Show(bool value)
    {
        Console.WriteLine(value ? "Число делится без остатка" : "Число не делится без остатка");
    }

    static void Main(string[] args)
    {
        Class1 class1 = new Class1();
        Class2 class2 = new Class2();

        Class1.ShowDelegate showDelegate = Show;

        Func<decimal, decimal, decimal> multiplyDelegate = class1.Multiply;
        Func<decimal, bool> resultDelegate = class2.Calc(multiplyDelegate, 19, 79);

        showDelegate(resultDelegate(2));
    }
}