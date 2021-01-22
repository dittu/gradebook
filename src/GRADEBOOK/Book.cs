using System;
using System.Collections.Generic;

namespace GRADEBOOK
{
    public class Book
    {

        List<double> grades;
        string name;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);

        }

        public Statistics GetStatistics()
        {
            Statistics res = new Statistics();

            res.Average = 0.0;
            res.High = double.MinValue;
            res.Low = double.MaxValue;

            foreach (var num in grades)
            {
                res.High = Math.Max(num, res.High);
                res.Low = Math.Min(num, res.Low);
                res.Average += num;
            }

            res.Average /= grades.Count;

            return res;
        }
    }
}