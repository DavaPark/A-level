namespace HomeWork17
{

    class Program
    {
        static void Main(string[] args)
        {
            MessageBox messageBox = new MessageBox();
            messageBox.WindowClosed += (sender, eventArgs) =>
            {
                if (eventArgs.State == State.Ok)
                {
                    Console.WriteLine("Операция подтверждена");
                }
                else
                {
                    Console.WriteLine("Операция отклоненно");
                }
            };
            messageBox.Open();

            Console.ReadLine();
        }
    }
}