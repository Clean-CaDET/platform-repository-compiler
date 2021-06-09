using SmartTutor.ProgressModel.Progress.EventSourcingInfrastructure;
using System;

namespace SmartTutor.ProgressModel.Progress.Events
{
    public class LearningObjectEvent : DomainEvent
    {
        public int LearningObjectId { get; private set; }

        public LearningObjectEvent(int id, int learningObjectId, DateTime timestamp) : base(id, timestamp)
        {
            LearningObjectId = learningObjectId;
        }
    }
}
