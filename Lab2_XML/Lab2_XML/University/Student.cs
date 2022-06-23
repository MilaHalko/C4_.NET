﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_XML
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Group { get; set; }
        public DateTime BirthDate { get; set; }

        public int SupervisorID { get; set; }


        public Dictionary<Subject, int> Scores = new Dictionary<Subject, int>();
        public float AverageScore
        {
            get
            {
                float sum = 0;
                foreach (var score in Scores)
                {
                    sum += score.Value;
                };
                return sum / Scores.Count;
            }
        }

        public override string ToString()
        {
            return String.Format(@"Student: {0} {1} {2} ID: {3} Group: {4}", LastName, FirstName, Patronymic, Id, Group);
        }
    }
}