using System;

namespace SmartTutor.ProgressModel.Progress.Events.SessionLifecycleEvents
{
    public class LearningSessionFinished : LearningSessionEvent
    {
        public DateTime SessionStartTimestamp { get; set; }
        public TimeSpan SessionDuration { get; set; }

        public LearningSessionFinished(int id, DateTime timestamp) : base(id, timestamp)
        {
        }
    }
}
