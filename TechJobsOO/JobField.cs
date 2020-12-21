using System;
namespace TechJobsOO
{
    public class JobField
    {
        public int Id { get; set; }
        private static int nextId = 1;

        public JobField()
        {
            Id = nextId;
            nextId++;
        }


    }
}
