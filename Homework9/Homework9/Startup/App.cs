using System;

public class App
{
    public static void Run()
    {
        Random random = new Random();

        for (int i = 0; i < 100; i++)
        {
            Action action = random.Next(2) switch
            {
                0 => (Action)Actions.StartMethod,
                1 => Actions.SkipLogic,
                2 => Actions.BreakLogic,
                _ => throw new NotImplementedException(),
            };

            try
            {
                action();
            }
            catch (BusinessException e)
            {
                Logger.Log("Warning", $"Action got this custom Exception: {e.Message}");
            }
            catch (Exception e)
            {
                Logger.Log("Error", $"Action failed by reason: {e.Message}");
            }
        }
    }
}