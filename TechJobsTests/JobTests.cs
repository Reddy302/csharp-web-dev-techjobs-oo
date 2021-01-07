using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job emptyConstructorJob1;
        Job emptyConstructorJob2;
        Job fullJob1;
        Job fullJob2;
        Job fullJob3;
        Job fullJob4;

        [TestInitialize]
        public void CreateJobObjects()
        {
            emptyConstructorJob1 = new Job();
            emptyConstructorJob2 = new Job();
            // Add constructor arguments below
            fullJob1 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            fullJob2 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            fullJob3 = new Job("Product tester", "ACME", "", "Quality control", "Persistence");
            fullJob4 = new Job("Product tester", "ACME", "Desert", "Quality control", "");
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsTrue(emptyConstructorJob1.Id + 1 == emptyConstructorJob2.Id && emptyConstructorJob1.Id != emptyConstructorJob2.Id);
            Assert.IsTrue(fullJob1.Id + 1 == fullJob2.Id && fullJob1.Id != fullJob2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(fullJob1.Name, "Product tester");
            Assert.AreEqual(fullJob1.EmployerName.Value, "ACME");
            Assert.AreEqual(fullJob1.EmployerLocation.Value, "Desert");
            Assert.AreEqual(fullJob1.JobType.Value, "Quality control");
            Assert.AreEqual(fullJob1.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(fullJob1.Equals(fullJob2));
        }

        [TestMethod]
        public void ToStringBeginsAndEndsWithNewLine()
        {
            Assert.IsTrue(fullJob1.ToString().StartsWith("\n"));
            Assert.IsTrue(fullJob1.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void ToStringIncludesFieldLabelsAndData()
        {
            Assert.IsTrue(fullJob1.ToString().Contains("\nID: "));
            Assert.IsTrue(fullJob1.ToString().Contains("\nName: Product tester"));
            Assert.IsTrue(fullJob1.ToString().Contains("\nEmployer: ACME"));
            Assert.IsTrue(fullJob1.ToString().Contains("\nLocation: Desert"));
            Assert.IsTrue(fullJob1.ToString().Contains("\nPosition Type: Quality control"));
            Assert.IsTrue(fullJob1.ToString().Contains("\nCore Competency: Persistence"));
        }

        [TestMethod]
        public void ToStringEmptyFieldReturnsDataNotAvailable()
        {
            Assert.AreEqual(fullJob3.EmployerLocation.Value, "Data not available");
            Assert.IsTrue(fullJob3.ToString().Contains("\nLocation: Data not available\n"));
            Assert.AreEqual(fullJob4.JobCoreCompetency.Value, "Data not available");
            Assert.IsTrue(fullJob4.ToString().Contains("\nCore Competency: Data not available\n"));
        }

        [TestMethod]
        public void EmptyJobReturnsJobDoesNotExist()
        {
            Assert.AreEqual(emptyConstructorJob1.ToString(), "OOPS! This job does not seem to exist.");
        }
    }
}
