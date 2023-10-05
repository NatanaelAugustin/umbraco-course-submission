using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using umbraco_course_submission.Models;
using umbraco_course_submission.Service;

namespace umbraco_course_submission.Controllers;

public class ContactsController : SurfaceController
{
    public ContactsController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
    }


    [HttpPost]
    public IActionResult Index(ContactForm contactForm)
    {
        if (!ModelState.IsValid)
            return CurrentUmbracoPage();

        using var mail = new MailService("no-reply@umbraco.com", "smtp.Umbraco.se", 587, "Umbraco@natanael.augustin.com", "bytmig123");

        mail.SendAsync(contactForm.Email, "Thank you for for reaching out to us.", "we'll be in contact as soon as possible.").ConfigureAwait(false);

        mail.SendAsync("umbraco@natanael.augustin.com", $"{contactForm.Name} sent a request", contactForm.Message).ConfigureAwait(false);

        return LocalRedirect(contactForm.RedirectUrl ?? "/");

    }
}