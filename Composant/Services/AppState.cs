namespace Composant.Services;

public class AppState
{
    public int CounterValue { get; set; }

    public event Action? OnChange;

    public void IncrementCounter()
    {
        CounterValue++;
        NotifyStateChanged();
    }
    
    public void ResetCounter()
    {
        CounterValue = 0;
        NotifyStateChanged();
    }

    public void NotifyStateChanged() => OnChange?.Invoke();
}