using System;

namespace SmartTutor.ProgressModel.Progress.Events.LearningObjectInteractionEvents
{
    public class LearningObjectInteractionEvent : LearningObjectEvent
    {
        public LearningObjectInteractionEvent(int id, int learningObjectId, DateTime timestamp) : base(id, learningObjectId, timestamp)
        {
        }
    }
}
