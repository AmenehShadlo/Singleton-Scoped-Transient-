namespace youtube_Dependency_Injection.Services
{
    public interface ILifeTimeService
    {
        List<LifeTime> GetLifeTimes();

        void AddToLifeTime();
    }
}
