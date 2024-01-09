using System;


namespace homework5
{
    public static class Starter
    {
        public static void Run(Logger logger)
        {
            for (int i = 0; i < 15; i++)
            {
                Result result = new();
                Random random = new Random();
                int randomNumbers = random.Next(1, 4);
                switch (randomNumbers)
                {
                    case 1:
                        result = Actions.InfoAction();
                        break;
                    case 2:
                        result = Actions.ErrorAction();
                        break;
                    case 3:
                        result = Actions.WarningAction();
                        break;
                }

                logger.AddLog(result);
            }
        }
    }
}