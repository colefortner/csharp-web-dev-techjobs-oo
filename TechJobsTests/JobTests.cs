using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job jobOne = new Job();
            Job jobTwo = new Job();
            Assert.IsFalse(jobOne.Id == jobTwo.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job jobOne = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", jobOne.Name);
            Assert.AreEqual("ACME", jobOne.EmployerName.Value);
            Assert.AreEqual("Desert", jobOne.EmployerLocation.Value);
            Assert.AreEqual("Quality control", jobOne.JobType.Value);
            Assert.AreEqual("Persistence", jobOne.JobCoreCompetency.value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job jobOne = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job jobTwo = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.Equals(jobOne, jobTwo);
        }

        [TestMethod]
        public void DoesToStringWork()
        {
            Job jobOne = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            //Console.WriteLine(jobOne.ToString());
            //Console.WriteLine("hello\nworld");
            //Assert.AreEqual("TechJobsOO.Job", jobOne.ToString());
            //Assert.AreEqual(Environment.NewLine + jobOne.ToString() + Environment.NewLine, jobOne.ToString());
            string word = "word";
            Console.WriteLine(word[0]);
            Console.WriteLine(word[word.Length -1]);
            Console.WriteLine(jobOne.ToString());
            Assert.IsTrue(jobOne.ToString()[0] == '\n');
            Assert.IsTrue(jobOne.ToString()[jobOne.ToString().Length -1] == '\n');
        }

        [TestMethod]
        public void MoreToStringNonsense()
        {
            Job jobOne = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(jobOne.ToString().Contains("\nID: " + jobOne.Id +"\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nName: Product tester\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nEmployer: ACME\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nLocation: Desert\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nPosition Type: Quality control\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nCore Competency: Persistence\n"));
            Console.WriteLine(jobOne.ToString());
        }

        [TestMethod]
        public void NoNameDataPassedIn()
        {
            Job jobOne = new Job("", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(jobOne.ToString().Contains("\nID: " + jobOne.Id + "\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nName: Data not available\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nEmployer: ACME\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nLocation: Desert\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nPosition Type: Quality control\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nCore Competency: Persistence\n"));
        }

        [TestMethod]
        public void NoEmployerDataPassedIn()
        {
            Job jobOne = new Job("Product tester", new Employer(""), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(jobOne.ToString().Contains("\nID: " + jobOne.Id + "\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nName: Product tester\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nEmployer: Data not available\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nLocation: Desert\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nPosition Type: Quality control\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nCore Competency: Persistence\n"));
        }

        [TestMethod]
        public void NoLocationDataPassedIn()
        {
            Job jobOne = new Job("Product tester", new Employer("ACME"), new Location(""), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(jobOne.ToString().Contains("\nID: " + jobOne.Id + "\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nName: Product tester\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nEmployer: ACME\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nLocation: Data not available\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nPosition Type: Quality control\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nCore Competency: Persistence\n"));
        }

        [TestMethod]
        public void NoPositionTypeDataPassedIn()
        {
            Job jobOne = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType(""), new CoreCompetency("Persistence"));
            Assert.IsTrue(jobOne.ToString().Contains("\nID: " + jobOne.Id + "\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nName: Product tester\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nEmployer: ACME\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nLocation: Desert\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nPosition Type: Data not available\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nCore Competency: Persistence\n"));
        }

        [TestMethod]
        public void NoCoreCompetencyDataPassedIn()
        {
            Job jobOne = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency(""));
            Assert.IsTrue(jobOne.ToString().Contains("\nID: " + jobOne.Id + "\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nName: Product tester\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nEmployer: ACME\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nLocation: Desert\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nPosition Type: Quality control\n"));
            Assert.IsTrue(jobOne.ToString().Contains("\nCore Competency: Data not available\n"));
        }

        [TestMethod]
        public void BonusNoDataExceptIdMessage()
        {
            Job jobOne = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            Assert.AreEqual("\nOOPS! This job does not seem to exist\n", jobOne.ToString());
        }
    }
}
