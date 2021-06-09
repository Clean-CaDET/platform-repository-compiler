using System;

namespace SmartTutor.ProgressModel.Progress.Events.LearningObjectInteractionEvents
{
    public class LearningObjectInteraction : LearningObjectEvent
    {
        public LearningObjectInteraction(int id, int learningObjectId, DateTime timestamp) : base(id, learningObjectId, timestamp)
        {
        }
    }
}
