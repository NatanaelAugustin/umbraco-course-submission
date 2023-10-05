using System.ComponentModel.DataAnnotations;

namespace umbraco_course_submission.Models
{
    public class NewsLetterForm
    {
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; } = null!;
    }
}
