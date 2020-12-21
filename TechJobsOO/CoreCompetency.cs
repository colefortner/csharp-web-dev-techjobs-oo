using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        public string value { get; set; }

        // TODO: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
        }

        public CoreCompetency(string v) : base()
        {
            value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return value;
        }
    }
}

