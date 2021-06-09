using System;

namespace SmartTutor.ProgressModel.Progress.Events.SessionLifecycleEvents
{
    public class LearningObjectUnfocused : LearningObjectEvent
    {
        public DateTime FocusStartTimeStamp { get; set; }
        public TimeSpan FocusDuration { get; set; }
        public TimeSpan TotalFocusDurationInSession { get; set; }

        public LearningObjectUnfocused(int id, int learningObjectId, DateTime timestamp) : base(id, learningObjectId, timestamp)
        {
        }
    }
}
