using System;

namespace SmartTutor.ProgressModel.Progress.Events.SessionLifecycleEvents
{
    public class LearningSessionStarted : LearningSessionEvent
    {
        public LearningSessionStarted(int id, DateTime timestamp) : base(id, timestamp)
        {
        }
    }
}
