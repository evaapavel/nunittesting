using NUnit.Framework;
using SimpleNUnitTests.People;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;



namespace TestsInNUnit.People
{



    [TestFixture]
    public class FileParserTest
    {



        [SetUp]
        public void Setup()
        {
            String cultureString = "en-US";
            //String cultureString = "cs-CZ";
            CultureInfo ci = new CultureInfo(cultureString);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }



        [Test]
        public void ParsePersonsTestOne()
        {
            string fileName = @"..\..\..\People\TestDataSet001.csv";
            FileParser fileParser = new FileParser(fileName);
            IList<Person> persons = fileParser.ParsePersons();
            Person samanthaMarvel = ((List<Person>)persons).Find(p => (p.FirstName == "Samantha") && (p.LastName == "Marvel"));
            Assert.AreEqual(new DateTime(1965, 1, 2), samanthaMarvel.DateOfBirth, "Samantha Marvel's birth date parsed value is incorrect.");
        }



        [Test]
        public void ParsePersonsTestTwo()
        {
            string fileName = @"..\..\..\People\TestDataSet002.csv";
            FileParser fileParser = new FileParser(fileName);
            IList<Person> persons = fileParser.ParsePersons();
            Assert.IsTrue(((List<Person>)persons).Exists(p => (p.FirstName == "Michelle") && (p.LastName == "Blanche")), "Missing Michelle Blanche!");
            Assert.IsTrue(((List<Person>)persons).Exists(p => (p.FirstName == "Mary") && (p.LastName == "Smith")), "Missing Mary Smith!");
            Assert.IsTrue(((List<Person>)persons).Exists(p => (p.FirstName == "Michael") && (p.LastName == "Brown")), "Missing Michael Brown!");
        }



    }



}
