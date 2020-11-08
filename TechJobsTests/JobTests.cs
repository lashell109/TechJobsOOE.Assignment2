using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job objectOne = new Job();
            Job objectTwo = new Job();

            Assert.IsTrue(objectOne.Id != objectTwo.Id && (objectOne.Id + 1) == objectTwo.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job objectThree = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"),
                new CoreCompetency("Persistence"));
            {
                Assert.IsTrue(objectThree.Name == "Product tester");
                Assert.IsTrue(objectThree.EmployerName.Value == "ACME");
                Assert.IsTrue(objectThree.EmployerLocation.Value == "Desert");
                Assert.IsTrue(objectThree.JobType.Value == "Quality control");
                Assert.IsTrue(objectThree.JobCoreCompetency.Value == "Persistence");
            }
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job objectOne = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"),
                new CoreCompetency("Persistence"));
            {
            };
            Job objectTwo = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"),
               new CoreCompetency("Persistence"));
            {
            };
                Assert.IsFalse(objectOne.Equals(objectTwo));
        }
        [TestMethod]
        public void TestToString()
        {
            Job objectFour = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"),
               new CoreCompetency("Persistence"));
            {
                string output = " ";
                Assert.AreEqual(output, objectFour.ToString());
            }
        }
    }
}
