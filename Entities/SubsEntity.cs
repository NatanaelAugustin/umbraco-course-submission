using System.ComponentModel.DataAnnotations;

namespace umbraco_course_submission.Entities
{
    public class SubsEntity
    {
        [Key]
        public string Email { get; set; } = null!;
    }
}
