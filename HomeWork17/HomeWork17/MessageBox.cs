
public class MessageBox
{
    public event EventHandler<StateEventArgs> WindowClosed;

    public async void Open()
    {
        Console.WriteLine("Окно открыток");
        await Task.Delay(3000); 
        Console.WriteLine("Окно закрыл пользователь");

        // Генеруємо випадковий стан
        State randomState = (State)(new Random().Next(2));
        OnWindowClosed(randomState);
    }

    protected virtual void OnWindowClosed(State state)
    {
        WindowClosed?.Invoke(this, new StateEventArgs(state));
    }
}