using System;

namespace SmartTutor.ProgressModel.Progress.Events.SessionLifecycleEvents
{
    public class LearningSessionUnpaused : LearningSessionEvent
    {
        public DateTime PauseStartTimestamp { get; private set; }
        public TimeSpan PauseDuration { get; private set; }

        public LearningSessionUnpaused(int id, DateTime timestamp) : base(id, timestamp)
        {
        }
    }
}
