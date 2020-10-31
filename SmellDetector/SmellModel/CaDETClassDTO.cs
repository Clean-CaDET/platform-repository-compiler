﻿using System.Collections.Generic;
using SmellDetector.Controllers;

namespace SmellDetector.SmellModel
{
    public class CaDETClassDTO
    {
        public Dictionary<string, MetricsDTO> IdentifierAnalyses { get; set; }

        public CaDETClassDTO()
        {
            IdentifierAnalyses = new Dictionary<string, MetricsDTO>();
        }

    }
}