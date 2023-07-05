namespace Vetero.Persistance.Helpers
{
    public static class DateHelper
    {
        public static string GetTodayDateString(string hour, string minutes)
        {
            return $"{DateTime.Now.Date} {hour}:{minutes}";
        }
    }
}
