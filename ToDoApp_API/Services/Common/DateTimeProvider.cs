using ToDoApp_API.Services.Common.Interfaces;

namespace ToDoApp_API.Services.Common
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
