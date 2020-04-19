using System;



namespace SimpleNUnitTests
{



    /// <summary>
    /// Simplifies the usage of this app's URLs.
    /// </summary>
    public class AppUrl
    {



        /// <summary>Protocol (http/https).</summary>
        private String protocol;

        /// <summary>Hostname (domain).</summary>
        private String hostname;

        /// <summary>Port (the default is 80 for HTTP and 443 for HTTPS).</summary>
        private Nullable<Int32> port;

        /// <summary>Route to the list of projects.</summary>
        private String projectRoute;

        /// <summary>Route to the company contact page.</summary>
        private String contactRoute;



        /// <summary>
        /// Constructor.
        /// </summary>
        public AppUrl()
        {
            protocol = "https";
            hostname = "www.projectliner.com";
            port = null;
            //projectRoute = "/projectList";
            projectRoute = "/project/list";
            contactRoute = "/contact";
        }



        /// <summary>Gets the type of the transfer protocol.</summary>
        public String Protocol
        {
            get { return protocol; }
        }

        /// <summary>Gets the hostname.</summary>
        public String Hostname
        {
            get { return hostname; }
        }

        /// <summary>Gets the port number.</summary>
        public Nullable<Int32> Port
        {
            get { return port; }
        }

        /// <summary>Gets the route to the list of projects.</summary>
        public String ProjectRoute
        {
            get { return projectRoute; }
        }

        /// <summary>Gets the route to the contact page.</summary>
        public String ContactRoute
        {
            get { return contactRoute; }
        }



        /// <summary>
        /// Gets the root URL for the app.
        /// </summary>
        /// <returns>Return the app's root URL.</returns>
        public String getRootUrl()
        {
            return protocol + "://" + hostname + (port != null ? ":" + port.ToString() : "");
        }



        /// <summary>
        /// Gets the URL for the project list.
        /// </summary>
        /// <returns>Returns the project list's URL.</returns>
        public String getProjectUrl()
        {
            return getRootUrl() + projectRoute;
        }



        /// <summary>
        /// Gets the URL for the contacts.
        /// </summary>
        /// <returns>Returns the contact's URL.</returns>
        public String getContactUrl()
        {
            return getRootUrl() + contactRoute;
        }



    }



}
