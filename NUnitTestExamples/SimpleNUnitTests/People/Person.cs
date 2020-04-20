using System;



namespace SimpleNUnitTests.People
{



    /// <summary>
    /// Represents a human being.
    /// </summary>
    public class Person
    {



        /// <summary>Id of this person.</summary>
        private Int32 id;

        /// <summary>First name of the person.</summary>
        private String firstName;

        /// <summary>Last name of the person.</summary>
        private String lastName;

        /// <summary>Date of birth of the person.</summary>
        private DateTime dateOfBirth;

        /// <summary>True :-: the person is allowed to drive a car, false :-: the person is NOT allowed to drive cars.</summary>
        private Boolean drivingLicence;



        /// <summary>
        /// Constructor.
        /// </summary>
        public Person()
        {
        }



        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="id">Id of the new person.</param>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName">Last name.</param>
        /// <param name="dateOfBirth">The person's date of birth.</param>
        /// <param name="drivingLicence">True :-: the person can drive, false :-: the person cannot drive.</param>
        public Person(Int32 id, String firstName, String lastName, DateTime dateOfBirth, Boolean drivingLicence)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.drivingLicence = drivingLicence;
        }



        /// <summary>Gets/set the id.</summary>
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>Gets/sets the first name.</summary>
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>Gets/sets the last name.</summary>
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>Gets/sets the date of birth of this person.</summary>
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        /// <summary>Gets/sets info on the person's driving licence.</summary>
        public Boolean DrivingLicence
        {
            get { return drivingLicence; }
            set { drivingLicence = value; }
        }



        /// <summary>
        /// Gets a string representation of this instance.
        /// </summary>
        /// <returns>Returns this instance's data as a string.</returns>
        public override string ToString()
        {
            //return String.Format("Id: {0,5}   First name: {1,10}   Last name: {2,15}   Date of birth: {3,10}   Driving licence: {4,8}", id, firstName, lastName, dateOfBirth, drivingLicence);
            //return String.Format("Id: {0,5}   First name: {1,10}   Last name: {2,15}   Date of birth: {3,10}   Driving licence: {4,8}", id, firstName, lastName, dateOfBirth.ToShortDateString(), drivingLicence);
            return String.Format("Id: {0,-5}   First name: {1,-10}   Last name: {2,-15}   Date of birth: {3,-10}   Driving licence: {4,-8}", id, firstName, lastName, dateOfBirth.ToShortDateString(), drivingLicence);
        }



    }



}
