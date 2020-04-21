//using SimpleNUnitTests.People;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;



namespace MyApp
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


            // Prepare a URL helper object.
            AppUrl appUrl = new AppUrl();

            // Display the root URL.
            Console.WriteLine("The application root is:     {0}", appUrl.GetRootUrl());

            // Display the projects' URL.
            Console.WriteLine("The project list page is:    {0}", appUrl.GetProjectUrl());

            // Display the contacts' URL.
            Console.WriteLine("The contacts' page is:       {0}", appUrl.GetContactUrl());

            // Leave out an empty line.
            Console.WriteLine();

            // Stop the execution until the user presses ENTER.
            Console.Write("Press ENTER to finish the app.");
            Console.ReadLine();

        }



    }



}
