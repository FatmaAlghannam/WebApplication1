using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AddEmployeeform
    {
        [Required] public string Name { get; set; }

        [Display(Name="Civil ID")] public string CivilID { get; set; }

        [EmailAddress] public string Email { get; set; }

        [StringLength(100)] public string DepartmentName { get; set; }

        [RegularExpression("^(\\+965[569]\\d{7})$")] public string Phone { get; set; }

        [Required] public bool  IsManger { get; set; }
        [Range(0, 1000)]  public decimal Salary { get; set; }



    }
}