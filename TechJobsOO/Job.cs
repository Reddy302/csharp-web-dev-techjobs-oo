using System;
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

        public Job(string name, string employerName, string employerLocation, string jobType, string jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = new Employer(employerName);
            EmployerLocation = new Location(employerLocation);
            JobType = new PositionType(jobType);
            JobCoreCompetency = new CoreCompetency(jobCoreCompetency);
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
            if (this.Name == null && this.EmployerName == null && this.EmployerLocation == null && this.JobType == null && this.JobCoreCompetency == null)
            {
                return "OOPS! This job does not seem to exist.";
            }
            else
            {
                return $"\nID: {this.Id}\nName: {this.Name}\nEmployer: {this.EmployerName}\nLocation: {this.EmployerLocation}\nPosition Type: {this.JobType}\nCore Competency: {this.JobCoreCompetency}\n";
            }
        }
    }
}
