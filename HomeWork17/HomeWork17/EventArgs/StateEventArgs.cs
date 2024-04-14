public class StateEventArgs : EventArgs
{
    public StateEventArgs(State state)
    {
        State = state;
    }

    public State State { get; }
}