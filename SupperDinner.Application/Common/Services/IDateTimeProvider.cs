namespace SupperDinner.Application.Common.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}