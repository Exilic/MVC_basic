using System;
using System.Collections.Generic;

namespace MVCBasicsAssignment.Models
{
    public class PersonLife
    {

        static List<LifeEvent> fullLife = new List<LifeEvent>()
        {
            new LifeEvent() { Kind = "Work", Period = "2014-2020", Description = "Teacher"},
            new LifeEvent() { Kind = "Work", Period = "2012-2013", Description = "Researcher"},
            new LifeEvent() { Kind = "Work", Period = "2005-2012", Description = "Own company"},
            new LifeEvent() { Kind = "Education", Period = "2010", Description = "PhD, Architecture, Chalmers TH"},
            new LifeEvent() { Kind = "Education", Period = "2000", Description = "Masters, Architecture, Chalmers TH"}
        };

        public void AddWork(string period, string description)
        {
            fullLife.Add(new LifeEvent() { Kind = "Work", Period = period, Description = description });
        }

        public void AddEducation(string period, string description)
        {
            fullLife.Add(new LifeEvent() { Kind = "Education", Period = period, Description = description });
        }

        public List<LifeEvent> All()
        {
            return fullLife;
        }
    }
}
