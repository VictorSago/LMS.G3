using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LMS.Core.Validation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LMS.Core.Entities.ViewModels
{
    public class NewUserViewModel
    {
        [Remote(action: "VerifyName", controller: "Courses", AdditionalFields = nameof(LastName))]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name must be between 3 to 50 characters")]
        public string FirstName { get; set; }

        [Remote(action: "VerifyName", controller: "Courses", AdditionalFields = nameof(FirstName))]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 to 50 characters")]
        public string LastName { get; set; }

        [Required]
        public string RoleType { get; set; }

        [Remote(action: "VerifyEmail", controller: "Courses")]
        [Display(Name ="Email address")]
        [Required(ErrorMessage ="The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Remote(action: "VerifyPassword", controller: "Courses", AdditionalFields = nameof(ConfirmPassword))]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "The confirm password is required")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public int CourseId { get; set; }

        public IEnumerable<SelectListItem> GetAllCourses { get; set; }
    }
}
