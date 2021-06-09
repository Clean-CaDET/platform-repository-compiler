using System;
using System.Collections.Generic;

namespace SmartTutor.ProgressModel.Progress.EventSourcingInfrastructure
{
    public abstract class EventSourcedAggregate
    {
        public List<DomainEvent> Changes { get; private set; }

        public EventSourcedAggregate()
        {
            Changes = new List<DomainEvent>();
        }

        public abstract void Apply(DomainEvent @event);
    }
}
