using System.ComponentModel.DataAnnotations;

namespace umbraco_course_submission.Models
{
    public class NewsLetterForm
    {
        [Required]
        public string Email { get; set; } = null!;
    }
}
