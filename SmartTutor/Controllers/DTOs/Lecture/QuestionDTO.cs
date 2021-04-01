﻿using System.Collections.Generic;

namespace SmartTutor.Controllers.DTOs.Lecture
{
    public class QuestionDTO : LearningObjectDTO
    {
        public string Text { get; set; }
        public List<string> PossibleAnswers { get; set; }
    }
}