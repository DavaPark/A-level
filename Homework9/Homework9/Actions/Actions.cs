public class Actions
{
    public static void StartMethod()
    {
        string methodName = "StartMethod";
        Logger.Log("Info", $"Start method: {methodName}");
    }

    public static void SkipLogic()
    {
        throw new BusinessException("Skipped logic in method");
    }

    public static void BreakLogic()
    {
        throw new Exception("I broke a logic");
    }
}