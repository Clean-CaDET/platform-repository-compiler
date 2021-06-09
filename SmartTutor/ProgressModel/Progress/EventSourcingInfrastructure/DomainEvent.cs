using System;

namespace SmartTutor.ProgressModel.Progress.EventSourcingInfrastructure
{
    public abstract class DomainEvent
    {
        public int Id { get; private set; }
        public DateTime Timestamp { get; private set; }

        protected DomainEvent(int id, DateTime timestamp)
        {
            Id = id;
            Timestamp = timestamp;
        }
    }
}
