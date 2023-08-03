using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication_DotNet_MVC.Models
{
    public class Employee
    {
        public Employee()
        {
            //this.ListOfGender.Add(new SelectListItem() { Text = "Male", Value = "1" });
            //this.ListOfGender.Add(new SelectListItem() { Text = "Female", Value = "2" });
            //this.ListOfGender.Add(new SelectListItem() { Text = "Other", Value = "3" });

            this.ListOfGender.Add("Male", "1");
            this.ListOfGender.Add("Female", "2");
            this.ListOfGender.Add("Other", "3");
        }

        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [DisplayName("NewFirstName")]
        [StringLength(50, ErrorMessage = "Max length should not be more than 50")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [DisplayName("NewFirstName")]
        [StringLength(50, ErrorMessage = "Max length should not be more than 50")]
        public string LastName { get; set; }

        public Dictionary<string, string> ListOfGender { get; set; } = new Dictionary<string, string>();
    }

    //public class KeyValue
    //{
    //    public string key { get; set; }

    //    public string value { get; set; }
    //}
}