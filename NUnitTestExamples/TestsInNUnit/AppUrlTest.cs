using NUnit.Framework;
using SimpleNUnitTests;
using System;



namespace TestsInNUnit
{



    [TestFixture]
    public class AppUrlTest
    {



        /// <summary>Instance of the class to be tested.</summary>
        private AppUrl appUrl;



        [SetUp]
        public void Setup()
        {
            appUrl = new AppUrl();
        }



        [Test]
        public void TestRootUrl()
        {
            String rootUrl = appUrl.getRootUrl();
            Console.WriteLine("Testing the URL: {0}", rootUrl);
            Assert.IsTrue(Uri.IsWellFormedUriString(rootUrl, UriKind.Absolute), "This URL is not valid: {0}", rootUrl);
        }



        [Test]
        public void TestProjectUrl()
        {
            String projectUrl = appUrl.getProjectUrl();
            Console.WriteLine("Testing the URL: {0}", projectUrl);
            Assert.AreEqual("https://www.projectliner.com/project/list", projectUrl, "The URL of the project list is not as expected: {0}", projectUrl);
        }



        [Test]
        public void TestContactUrl()
        {
            String contactUrl = appUrl.getContactUrl();
            Console.WriteLine("Testing the URL: {0}", contactUrl);
            // ***
            //Assert.Pass(new Uri(contactUrl));
            //Assert.DoesNotThrow(new TestDelegate());
            //Assert.That(new Uri(contactUrl), NotTh);
            // ***
            //Assert.DoesNotThrow(() => new Uri(contactUrl), "Cannot create a URI from this: {0}", contactUrl);
            Assert.That(() => new Uri(contactUrl), Throws.Nothing);
        }



        [TearDown]
        public void Cleanup()
        {
            appUrl = null;
        }



    }



}
