using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObject
{
    /// <summary>
    /// Prepresents a individual college student
    /// </summary>
    public class Students
    {
        /// <summary>
        /// The unique ID for student
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// Student's first name
        /// </summary>
        public string FirstName { get; set; }


        /// <summary>
        /// Student's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Student's school email address
        /// </summary>
        public string SchoolEmail { get; set; }

        /// <summary>
        /// Student's phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Student's date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The assigned advisor for student
        /// </summary>
        public Advisors AssignedAdvisor { get; set; }
    }
}
