using System.ComponentModel.DataAnnotations;

namespace umbraco_course_submission.Models;

public class ContactForm
{
    [Required(ErrorMessage = "Please enter your name")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your email address")]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your message")]
    public string Message { get; set; } = null!;

    public string? RedirectUrl { get; set; } = "/contacts";
}
