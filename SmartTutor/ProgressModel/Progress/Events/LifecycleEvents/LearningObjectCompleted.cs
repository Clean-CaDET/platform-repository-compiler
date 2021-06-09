using System;

namespace SmartTutor.ProgressModel.Progress.Events.SessionLifecycleEvents
{
    public class LearningObjectCompleted : LearningObjectEvent
    {
        public LearningObjectCompleted(int id, int learningObjectId, DateTime timestamp) : base(id, learningObjectId, timestamp)
        {
        }
    }
}
