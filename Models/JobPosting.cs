using System.ComponentModel.DataAnnotations;

namespace JobApplicationMVCApp.Models;

public class JobPosting
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Title is required")]
    [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
    public string Title { get; set; }
    
    [Required(ErrorMessage = "Description is required")]
    [MaxLength(512, ErrorMessage = "Description cannot exceed 512 characters")]
    public string Description { get; set; }
    
    [Required(ErrorMessage = "Start date is required")]
    [DataType(DataType.Date)]
    [Display(Name = "Start Date")]
    public DateTime StartDate { get; set; }
    
    [Required(ErrorMessage = "Salary is required")]
    [Range(0, 1000000, ErrorMessage = "Salary must be between 0 and 1,000,000")]
    public decimal Salary { get; set; }
}