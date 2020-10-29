﻿using SmartTutor.ContentModel;
using SmartTutor.Repository;
using SmartTutor.Service;

namespace SmartTutor.Controllers
{
    public class ContentRepositoryController
    {
        public ContentService ContentService;

        public ContentRepositoryController()
        {
            // Change param in constructor for ContentService if you want to get some other repository implementation
            ContentService = new ContentService(new ContentInMemoryRepository());
        }

        public EducationContent FindContentForIssue(SmellType issue, int indexOfContent)
        {
            return ContentService.FindContentForIssue(issue, indexOfContent);
        }

    }
}
