﻿using Moq;
using Shouldly;
using SmartTutor.ContentModel;
using SmartTutor.ContentModel.LearningObjects;
using SmartTutor.ContentModel.LearningObjects.Repository;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SmartTutorTests.Unit
{
    public class NodeContentTests
    {
        private readonly ContentService _service;

        public NodeContentTests()
        {
            _service = new ContentService(null, null, CreateMockRepository(), null);
        }

        private static ILearningObjectRepository CreateMockRepository()
        {
            Mock<ILearningObjectRepository> learningObjectRepo = new Mock<ILearningObjectRepository>();
            learningObjectRepo.Setup(repo => repo.GetQuestionAnswers(19))
                .Returns(new List<QuestionAnswer>
                {
                    new QuestionAnswer
                    {
                        Id = 10, Text = "First.", IsCorrect = false, Feedback = "This statement is false.",
                        QuestionId = 19
                    },
                    new QuestionAnswer
                    {
                        Id = 11, Text = "Second.", IsCorrect = true, Feedback = "This statement is true.",
                        QuestionId = 19
                    },
                    new QuestionAnswer
                    {
                        Id = 12, Text = "Third.", IsCorrect = true, Feedback = "This statement is true.",
                        QuestionId = 19
                    },
                    new QuestionAnswer
                    {
                        Id = 13, Text = "Fourth.", IsCorrect = false, Feedback = "This statement is false.",
                        QuestionId = 19
                    }
                });
            learningObjectRepo.Setup(repo => repo.GetArrangeTaskContainers(32))
                .Returns(new List<ArrangeTaskContainer>
                {
                    new ArrangeTaskContainer
                    {
                        Id = 1, Elements = new List<ArrangeTaskElement>
                        {
                            new ArrangeTaskElement {Id = 1}
                        }
                    },
                    new ArrangeTaskContainer
                    {
                        Id = 2, Elements = new List<ArrangeTaskElement>
                        {
                            new ArrangeTaskElement {Id = 2}
                        }
                    },
                    new ArrangeTaskContainer
                    {
                        Id = 3, Elements = new List<ArrangeTaskElement>
                        {
                            new ArrangeTaskElement {Id = 3}
                        }
                    },
                    new ArrangeTaskContainer
                    {
                        Id = 4, Elements = new List<ArrangeTaskElement>
                        {
                            new ArrangeTaskElement {Id = 4}
                        }
                    },
                    new ArrangeTaskContainer
                    {
                        Id = 5, Elements = new List<ArrangeTaskElement>
                        {
                            new ArrangeTaskElement {Id = 5}
                        }
                    }
                });
            return learningObjectRepo.Object;
        }

        [Theory]
        [MemberData(nameof(AnswersTestData))]
        public void Evaluates_answer_submission(List<int> submittedAnswers, List<bool> expectedCorrectness)
        {
            var results = _service.EvaluateAnswers(19, submittedAnswers);

            var correctness = results.Select(a => a.SubmissionWasCorrect);
            correctness.ShouldBe(expectedCorrectness);
        }

        public static IEnumerable<object[]> AnswersTestData =>
            new List<object[]>
            {
                new object[]
                {
                    new List<int> {10, 11, 12, 13},
                    new List<bool> {false, true, true, false}
                },
                new object[]
                {
                    new List<int> {10, 13},
                    new List<bool> {false, false, false, false}
                },
                new object[]
                {
                    new List<int> {11, 12},
                    new List<bool> {true, true, true, true}
                }
            };

        [Theory]
        [MemberData(nameof(ArrangeTasksTestData))]
        public void Evaluates_arrange_task_submission(List<ArrangeTaskContainer> submittedAnswers,
            List<bool> expectedCorrectness)
        {
            var results = _service.EvaluateArrangeTask(32, submittedAnswers);

            var correctness = results.Select(a => a.SubmissionWasCorrect);
            correctness.ShouldBe(expectedCorrectness);
        }

        public static IEnumerable<object[]> ArrangeTasksTestData =>
            new List<object[]>
            {
                new object[]
                {
                    new List<ArrangeTaskContainer>
                    {
                        new ArrangeTaskContainer
                        {
                            Id = 1, Elements = new List<ArrangeTaskElement>
                            {
                                new ArrangeTaskElement {Id = 1},
                                new ArrangeTaskElement {Id = 5}
                            }
                        },
                        new ArrangeTaskContainer
                        {
                            Id = 2, Elements = new List<ArrangeTaskElement>
                            {
                                new ArrangeTaskElement {Id = 2}
                            }
                        },
                        new ArrangeTaskContainer
                        {
                            Id = 3, Elements = new List<ArrangeTaskElement>
                            {
                                new ArrangeTaskElement {Id = 3}
                            }
                        },
                        new ArrangeTaskContainer {Id = 4, Elements = new List<ArrangeTaskElement>()},
                        new ArrangeTaskContainer
                        {
                            Id = 5, Elements = new List<ArrangeTaskElement>
                            {
                                new ArrangeTaskElement {Id = 4}
                            }
                        }
                    },
                    new List<bool> {false, true, true, false, false}
                },
                new object[]
                {
                    new List<ArrangeTaskContainer>
                    {
                        new ArrangeTaskContainer
                        {
                            Id = 1, Elements = new List<ArrangeTaskElement>
                            {
                                new ArrangeTaskElement {Id = 1},
                                new ArrangeTaskElement {Id = 2},
                                new ArrangeTaskElement {Id = 3},
                                new ArrangeTaskElement {Id = 4},
                                new ArrangeTaskElement {Id = 5}
                            }
                        },
                        new ArrangeTaskContainer {Id = 2, Elements = new List<ArrangeTaskElement>()},
                        new ArrangeTaskContainer {Id = 3, Elements = new List<ArrangeTaskElement>()},
                        new ArrangeTaskContainer {Id = 4, Elements = new List<ArrangeTaskElement>()},
                        new ArrangeTaskContainer {Id = 5, Elements = new List<ArrangeTaskElement>()}
                    },
                    new List<bool> {false, false, false, false, false}
                },
                new object[]
                {
                    new List<ArrangeTaskContainer>
                    {
                        new ArrangeTaskContainer
                        {
                            Id = 1, Elements = new List<ArrangeTaskElement>
                            {
                                new ArrangeTaskElement {Id = 1}
                            }
                        },
                        new ArrangeTaskContainer
                        {
                            Id = 2, Elements = new List<ArrangeTaskElement>
                            {
                                new ArrangeTaskElement {Id = 2}
                            }
                        },
                        new ArrangeTaskContainer
                        {
                            Id = 3, Elements = new List<ArrangeTaskElement>
                            {
                                new ArrangeTaskElement {Id = 3}
                            }
                        },
                        new ArrangeTaskContainer
                        {
                            Id = 4, Elements = new List<ArrangeTaskElement>
                            {
                                new ArrangeTaskElement {Id = 4}
                            }
                        },
                        new ArrangeTaskContainer
                        {
                            Id = 5, Elements = new List<ArrangeTaskElement>
                            {
                                new ArrangeTaskElement {Id = 5}
                            }
                        }
                    },
                    new List<bool> {true, true, true, true, true}
                }
            };
    }
}