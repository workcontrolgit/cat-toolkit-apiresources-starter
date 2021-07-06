using Apiresources.Application.Interfaces;
using System;

namespace Apiresources.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}