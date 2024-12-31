
namespace youtube_Dependency_Injection.Services
{
    public class LifeTimeService : ILifeTimeService
    {
        private List<LifeTime> LifeTimes = new List<LifeTime>();
        public void AddToLifeTime()
        {
            LifeTimes.Add(new LifeTime { Text = GenerateRandomString() });
        }
        public List<LifeTime> GetLifeTimes()
        {
            return LifeTimes;
        }

        private string GenerateRandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
