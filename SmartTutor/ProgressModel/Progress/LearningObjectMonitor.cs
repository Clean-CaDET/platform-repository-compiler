using SmartTutor.ContentModel.LearningObjects;
using SmartTutor.ContentModel.Lectures;
using SmartTutor.ProgressModel.Progress.Events.LearningObjectInteractionEvents;
using System;
using System.Collections.Generic;

namespace SmartTutor.ProgressModel.Progress
{
    public abstract class LearningObjectMonitor
    {
        public LearningObject learningObject { get; private set; }

        public LearningObjectStateChange StartMonitoring(DateTime date)
        {
            throw new NotImplementedException();
        }

        public LearningObjectStateChange StopMonitoring(DateTime date)
        {
            throw new NotImplementedException();
        }

        public LearningObjectStateChange Interact(LearningObjectInteraction interaction)
        {
            throw new NotImplementedException();
        }

    }

    public enum LearningObjectStateChange
    {
        Incomplete,
        AlreadyComplete,
        Completed
    }
}
