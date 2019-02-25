using Service_plan_form.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_plan_form.Contracts
{
    public class Person
    {
        [DataNames("first_name", "firstName")]
        public string FirstName { get; set; }

        [DataNames("last_name", "lastName")]
        public string LastName { get; set; }

        [DataNames("dob", "dateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [DataNames("job_title", "jobTitle")]
        public string JobTitle { get; set; }

        [DataNames("taken_name", "nickName")]
        public string TakenName { get; set; }

        [DataNames("is_american", "isAmerican")]
        public bool IsAmerican { get; set; }
    }
}
