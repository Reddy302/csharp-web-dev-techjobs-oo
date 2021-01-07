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

        [TestInitialize]
        public void CreateJobObjects()
        {
            emptyConstructorJob1 = new Job();
            emptyConstructorJob2 = new Job();
            // Add constructor arguments below
            fullJob1 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            fullJob2 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
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
    }
}
