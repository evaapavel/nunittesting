using SimpleNUnitTests.People;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;



namespace SimpleNUnitTests
{



    /// <summary>
    /// Exposes the main application entry point.
    /// </summary>
    public class Program
    {



        /// <summary>
        /// Main application entry point.
        /// </summary>
        /// <param name="args">Command line parameters.</param>
        public static void Main(string[] args)
        {

            // Set the culture.
            String cultureString = "en-US";
            //String cultureString = "cs-CZ";
            CultureInfo ci = new CultureInfo(cultureString);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            // Give some debug info.
            //Console.WriteLine("Hi there!");

            // Give more info.
            //Console.WriteLine("Hello, mate!");

            // Give even more info.
            //Console.WriteLine("Yep, I'm here, buddy!");

            // Give one more log line.
            //Console.WriteLine("Keep thinking...");

            // Leave out a blank line.
            //Console.WriteLine();

            // Prepare a URL helper object.
            AppUrl appUrl = new AppUrl();

            // Display the root URL.
            Console.WriteLine("The application root is:     {0}", appUrl.GetRootUrl());

            // Display the projects' URL.
            Console.WriteLine("The project list page is:    {0}", appUrl.GetProjectUrl());

            // Display the contacts' URL.
            Console.WriteLine("The contacts' page is:       {0}", appUrl.GetContactUrl());

            // Leave out a blank line.
            Console.WriteLine();

            // Read persons from the example file.
            String fileName = @"..\..\People\InputDataExample.csv";
            FileParser fileParser = new FileParser(fileName);
            IList<Person> persons = fileParser.ParsePersons();

            // Display persons' info.
            Console.WriteLine("Persons:");
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }

            // Stop the execution until the user presses ENTER.
            Console.Write("Press ENTER to finish the app.");
            Console.ReadLine();

        }



        /// <summary>
        /// Operates with dates and/or times.
        /// </summary>
        private static void DoSomethingWithDateTime()
        {
            DateTime dateTime = new DateTime(2020, 4, 20);
        }



        /// <summary>
        /// Operates with booleans.
        /// </summary>
        private static void DoSomethingWithBoolean()
        {
            Boolean flag = true;
            //flag = Boolean.FalseString;
        }



    }



}
