using System;
using System.Collections.Generic;


namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

    public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }


        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string output = "\n";
            int counter = 0;
            Dictionary<string, string> jobObjectStringData = new Dictionary<string, string>
            {
                {"ID", Id.ToString() },
                {"Name", Name },
                {"Employer", EmployerName.Value },
                {"Location", EmployerLocation.Value },
                {"Position Type", JobType.Value },
                {"Core Competency", JobCoreCompetency.value }
            };

            foreach (KeyValuePair<string, string> job in jobObjectStringData)
            {
                //if (job.Value != null)
                if(job.Value != "")
                {
                    output = output  + job.Key + ": " + job.Value + "\n";
                    counter++;
                }
                else
                {
                    output = output + job.Key + ": " + "Data not available\n";
                }
            }

            if (counter == 1)
            {
                return "\nOOPS! This job does not seem to exist\n";
            }
            return output;
        }
    }
}

