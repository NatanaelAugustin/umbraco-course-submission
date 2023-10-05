using umbraco_course_submission.Context;
using umbraco_course_submission.Models;

namespace umbraco_course_submission.Service
{
    public class SubService
    {

        private readonly DataContext _context;

        public SubService(DataContext context)
        {
            _context = context;
        }

        public async Task AddSubsAsync(NewsLetterForm form)
        {
            if (_context.Subs != null)
            {
                _context.Subs.Add(new Entities.SubsEntity { Email = form.Email });
                await _context.SaveChangesAsync();
            }
        }
    }
}
