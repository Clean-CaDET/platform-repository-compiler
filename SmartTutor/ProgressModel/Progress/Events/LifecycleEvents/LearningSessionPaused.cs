using System;

namespace SmartTutor.ProgressModel.Progress.Events.SessionLifecycleEvents
{
    public class LearningSessionPaused : LearningSessionEvent
    {
        public TimeSpan SessionDuration { get; private set; }

        public LearningSessionPaused(int id, DateTime timestamp) : base(id, timestamp)
        {
        }
    }
}
