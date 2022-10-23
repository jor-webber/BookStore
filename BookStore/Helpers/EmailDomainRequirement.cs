using Microsoft.AspNetCore.Authorization;

namespace BookStore.Helpers
{
    public class EmailDomainRequirement : IAuthorizationRequirement
    {
        public string EmailDomain { get; }

        public EmailDomainRequirement(string emailDomain)
        {
            EmailDomain = emailDomain;
        }

    }
}
