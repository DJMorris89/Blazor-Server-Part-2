namespace BlazorApp.Data
{
    public interface ICounterService
    {
        int CounterValue { get; set; }

        void IncrementCounter();
    }
}