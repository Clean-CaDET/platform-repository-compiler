using System;

namespace SmartTutor.ProgressModel.Progress.Events.SessionLifecycleEvents
{
    public class LearningObjectFocused : LearningObjectEvent
    {
        public LearningObjectFocused(int id, int learningObjectId, DateTime timestamp) : base(id, learningObjectId, timestamp)
        {
        }
    }
}
