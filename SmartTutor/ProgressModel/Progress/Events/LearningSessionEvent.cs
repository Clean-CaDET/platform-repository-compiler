using SmartTutor.ProgressModel.Progress.EventSourcingInfrastructure;
using System;

namespace SmartTutor.ProgressModel.Progress.Events
{
    public class LearningSessionEvent : DomainEvent
    {
        // TODO: Add data about learner, node, and progress to be used for queries

        public LearningSessionEvent(int id, DateTime timestamp) : base(id, timestamp)
        {
        }
    }
}
