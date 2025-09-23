using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace DevNas.Bookings.Bookings
{
    public class TimeRange : ValueObject
    {
        public DateTime StartTime { get; protected set; }
        public DateTime EndTime { get; protected set; }

        protected TimeRange() { }

        public TimeRange(DateTime startTime, DateTime endTime)
        {
            if (endTime <= startTime)
            {
                throw new ArgumentException("EndTime must be greater than StartTime");
            }

            StartTime = startTime;
            EndTime = endTime;
        }

        public bool Overlaps(TimeRange other)
        {
            return StartTime < other.EndTime && EndTime > other.StartTime;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return StartTime;
            yield return EndTime;
        }
    }
}
