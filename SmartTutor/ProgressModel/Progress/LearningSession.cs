using SmartTutor.ContentModel.LearningObjects;
using SmartTutor.ContentModel.Lectures;
using SmartTutor.ProgressModel.Progress.Events.LearningObjectInteractionEvents;
using SmartTutor.ProgressModel.Progress.Events.SessionLifecycleEvents;
using SmartTutor.ProgressModel.Progress.EventSourcingInfrastructure;
using System;
using System.Collections.Generic;

namespace SmartTutor.ProgressModel.Progress
{
    public class LearningSession : EventSourcedAggregate
    {
        public int Id { get; private set; }
        public NodeProgress NodeProgress { get; set; }
        public Dictionary<int, LearningObjectMonitor> FocusedMonitors { get; private set; }
        public Dictionary<int, LearningObjectMonitor> IdleMonitors { get; private set; }

        public override void Apply(DomainEvent @event)
        {
            When((dynamic)@event);
        }

        public void Start(DateTime timestamp)
        {
            Causes(new LearningSessionStarted(Id, timestamp));
        }

        public void Pause(DateTime timestamp)
        {
            Causes(new LearningSessionPaused(Id, timestamp));
        }

        public void Unpause(DateTime timestamp)
        {
            Causes(new LearningSessionUnpaused(Id, timestamp));
        }

        public void Finish(DateTime timestamp)
        {
            Causes(new LearningSessionFinished(Id, timestamp));
        }

        public void FocusLearningObject(DateTime timestamp, int learningObjectId)
        {
            Causes(new LearningObjectFocused(Id, learningObjectId, timestamp));
        }

        public void UnfocusLearningObject(DateTime timestamp, int learningObjectId)
        {
            Causes(new LearningObjectUnfocused(Id, learningObjectId, timestamp));
        }

        public void InteractWithLearningObject(LearningObjectInteraction interaction)
        {
            // TODO: reconsider if this method should recieve the event or make a separate interaction hierarchy
            Causes(interaction);
        }

        private void Causes(DomainEvent @event)
        {
            Apply(@event);
            Changes.Add(@event);
        }

        private void When(LearningSessionStarted learningSessionStarted)
        {
            throw new NotImplementedException();
        }

        private void When(LearningSessionPaused learningSessionPaused)
        {
            throw new NotImplementedException();
        }

        private void When(LearningSessionUnpaused learningSessionUnpaused)
        {
            throw new NotImplementedException();
        }

        private void When(LearningSessionFinished learningSessionFinished)
        {
            throw new NotImplementedException();
        }

        private void When(LearningObjectFocused learningObjectFocused)
        {
            throw new NotImplementedException();
        }

        private void When(LearningObjectUnfocused learningObjectUnfocused)
        {
            throw new NotImplementedException();
        }

        private void When(LearningObjectInteraction learningObjectInteraction)
        {
            throw new NotImplementedException();
        }

        private void When(LearningObjectCompleted learningObjectCompleted)
        {
            throw new NotImplementedException();
        }

    }
}