using System;

namespace SmartTutor.ProgressModel.Progress.Events.LearningObjectInteractionEvents
{
    public class AnswerSubmitted : LearningObjectInteractionEvent
    {
        public AnswerSubmitted(int id, int learningObjectId, DateTime timestamp) : base(id, learningObjectId, timestamp)
        {
        }
    }
}
