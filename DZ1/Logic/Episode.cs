using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Episode
    {

        public int viewers;
        public double gradeSum;
        public double highestGrade;

        public Episode()
        {
            this.viewers = 0;
            this.gradeSum = 0;
            this.highestGrade = 0;
        }
        public Episode(int viewers, double gradeSum, double highestGrade)
        {
            this.viewers = viewers;
            this.gradeSum = gradeSum;
            this.highestGrade = highestGrade;
        }

        public void AddView(double grade)
        {
            viewers++;
            gradeSum += grade;
            if (highestGrade < grade)
            {
                highestGrade = grade;
            }
        }
        public double GetAverageScore()
        {
            double averageScore;
            averageScore = gradeSum / viewers;
            return averageScore;
        }
        public double GetMaxScore()
        {
            return highestGrade;
        }
        public int GetViewerCount()
        {
            return viewers;
        }

    }
}
