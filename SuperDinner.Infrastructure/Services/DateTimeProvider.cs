using SupperDinner.Application.Common.Services;

namespace SuperDinner.Infrastructure.Services;

public class DateTimeProvider:IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}