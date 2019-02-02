namespace Acme.CMS.Entities
{
    public class Customer
    {

        public Customer()
        {
            InstanceCount++;
        }
        /// <summary>
        /// Number of Customer instances.
        /// </summary>
        public static int InstanceCount { get; private set; }
        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Full name.
        /// </summary>
        public string FullName => $"{FirstName} {LastName}".Trim();

        /// <summary>
        /// Email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// CustomerId.
        /// </summary>
        public int CustomerId { get; private set; }


    }
}