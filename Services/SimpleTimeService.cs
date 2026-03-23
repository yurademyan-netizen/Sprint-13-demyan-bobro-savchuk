namespace Sprint_13_Dy_Sa_Bo.Services
{
    public class SimpleTimeService : ITimeService
    {
        public DateTime GetTimeForTomorrow()
        {
            return DateTime.Now.AddDays(1);
        }
    }
}
