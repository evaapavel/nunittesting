using System;
using System.Collections.Generic;
using System.IO;



namespace SimpleNUnitTests.People
{



    /// <summary>
    /// Helps to parse CSV files with persons' data.
    /// </summary>
    public class FileParser
    {



        /// <summary>Name of the file to parse.</summary>
        private String fileName;

        /// <summary>Temporary variable to store persons being parsed.</summary>
        private IList<Person> persons;

        /// <summary>File being parsed.</summary>
        private TextReader inputFile;



        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="fileName">Name of the file to parse.</param>
        public FileParser(String fileName)
        {
            this.fileName = fileName;
        }



        /// <summary>
        /// Parses the given file and returns a list of persons found in (and parsed from) the file.
        /// </summary>
        /// <returns>Returns a list of parsed persons.</returns>
        public IList<Person> ParsePersons()
        {

            // Prepare a resulting list.
            persons = new List<Person>();

            // Open the file for reading line by line.
            inputFile = File.OpenText(fileName);

            // Process each line.
            // Ignore the first line which just describes the file structure.
            Boolean isFirstLine = true;
            Int32 lineCounter = 0;
            for (;;)
            {

                // Read a line from the stream.
                String line = inputFile.ReadLine();

                // Exit the loop if all data has been processed.
                if (String.IsNullOrEmpty(line))
                {
                    break;
                }

                // Process the line.
                if (isFirstLine)
                {
                    isFirstLine = false;
                }
                else
                {
                    // Count processed lines.
                    lineCounter++;
                    // Skip persons the parsing of which fails.
                    try
                    {
                        Person person = ParsePerson(line);
                        persons.Add(person);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Person data at line {0} could not be parsed.", lineCounter);
                    }
                }

            }

            // Done.
            inputFile.Close();

            // Return the result.
            return persons;

        }



        /// <summary>
        /// Parses one line of the input data file and gets a person with that data.
        /// </summary>
        /// <param name="line">Line to parse.</param>
        /// <returns>Returns a person with data parsed from the given line.</returns>
        private Person ParsePerson(String line)
        {

            // Prepare a result.
            Person person = new Person();

            // Get line chunks.
            String[] chunks = line.Split(',');

            // Parse bits.
            Int32 id = Int32.Parse(chunks[0]);
            String firstName = chunks[1];
            String lastName = chunks[2];
            DateTime dateOfBirth = DateTime.Parse(chunks[3]);
            Boolean drivingLicence = Boolean.Parse(chunks[4]);

            // Set the parsed bits to the person's properties.
            person.Id = id;
            person.FirstName = firstName;
            person.LastName = lastName;
            person.DateOfBirth = dateOfBirth;
            person.DrivingLicence = drivingLicence;

            // Return the result.
            return person;

        }



    }



}
