using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication_DotNet_MVC.Models
{
    public class EmployeeDetails
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Gender { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
    }
}