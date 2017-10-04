﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _CRS__Criteria___Express_Entry
{
    class LanguagePoints
    {
        public enum LanguageExamTypes
        {
            IELTS = 1,
            CELPIP,
            TEF
        }

        LanguageExamTypes languageExamType;
        double speakingPoints;
        double writingPoints;
        double readingPoints;
        double listeningPoints;

        public LanguageExamTypes LanguageExamType
        {
            get
            {
                return languageExamType;
            }
            set
            {
                languageExamType = value;
            }
        }


        public double SpeakingPoints
        {
            get
            {
                return speakingPoints;
            }
            set
            {
                speakingPoints = value;
            }
        }


        public double WritingPoints
        {
            get
            {
                return writingPoints;
            }
            set
            {
                writingPoints = value;
            }
        }


        public double ReadingPoints
        {
            get
            {
                return readingPoints;
            }
            set
            {
                readingPoints = value;
            }
        }


        public double ListeningPoints
        {
            get
            {
                return listeningPoints;
            }
            set
            {
                listeningPoints = value;
            }
        }
    }
}
