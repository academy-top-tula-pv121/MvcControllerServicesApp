namespace MvcControllerServicesApp
{
    public interface ITimeService
    {
        string Time { get; }
    }

    public class TimeService : ITimeService
    {
        public string Time
        {
            get => DateTime.Now.ToString();
        }
    }
}
