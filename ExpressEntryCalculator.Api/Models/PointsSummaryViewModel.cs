﻿namespace ExpressEntryCalculator.Api.Models
{
    public class PointsSummaryViewModel
    {
        public int PointsForAge { get; set; }
        public int PointsForEducation { get; set; }
        public int PointsForFirstLanguage { get; set; }
        public int PointsForSecondLanguage { get; set; }
        public int PointsForCanadianExperience { get; set; }
        public int PointsInSectionA { get; set; }

        public int PointsForSpouseEducation { get; set; }
        public int PointsForSpouseLanguageExam { get; set; }
        public int PointsForSpouseCanadianExperience { get; set; }
        public int PointsInSectionB { get; set; }

        public int PointsInSectionC { get; set; }

        public int PointsInSectionD { get; set; }

        public int TotalPointsForExpressEntry { get; set; }
    }
}
