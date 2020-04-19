using System;



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

            // Give some debug info.
            Console.WriteLine("Hi there!");

            // Give more info.
            Console.WriteLine("Hello, mate!");

            // Give even more info.
            Console.WriteLine("Yep, I'm here, buddy!");

            // Give one more log line.
            Console.WriteLine("Keep thinking...");

            // Leave out a blank line.
            Console.WriteLine();

            // Prepare a URL helper object.
            AppUrl appUrl = new AppUrl();

            // Display the root URL.
            Console.WriteLine("The application root is:     {0}", appUrl.getRootUrl());

            // Display the projects' URL.
            Console.WriteLine("The project list page is:    {0}", appUrl.getProjectUrl());

            // Display the contacts' URL.
            Console.WriteLine("The contacts' page is:       {0}", appUrl.getContactUrl());

            // Leave out a blank line.
            Console.WriteLine();

            // Stop the execution until the user presses ENTER.
            Console.Write("Press ENTER to finish the app.");
            Console.ReadLine();

        }



    }



}
