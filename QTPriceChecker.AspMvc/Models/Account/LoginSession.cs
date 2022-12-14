//@CodeCopy
//MdStart
#if ACCOUNT_ON
namespace QTPriceChecker.AspMvc.Models.Account
{
    /// <summary>
    /// A model class for the login data.
    /// </summary>
    public partial class LoginSession
    {
        /// <summary>
        /// The reference to the identity.
        /// </summary>
        public int IdentityId { get; set; }
        /// <summary>
        /// The session token.
        /// </summary>
        public string SessionToken { get; set; } = string.Empty;
        /// <summary>
        /// The time of registration.
        /// </summary>
        public DateTime LoginTime { get; set; }

        /// <summary>
        /// The time of logout.
        /// </summary>
        public DateTime? LogoutTime { get; set; }

        /// <summary>
        /// The user name.
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// The user email.
        /// </summary>
        public string Email { get; set; } = string.Empty;
        /// <summary>
        /// The login info (optional).
        /// </summary>
        public string? OptionalInfo { get; set; }
        /// <summary>
        /// The login roles.
        /// </summary>
        public AccessRole[] Roles { get; set; } = Array.Empty<AccessRole>();

        public static LoginSession Create(Logic.Models.Account.LoginSession other)
        {
            return new LoginSession
            {
                IdentityId = other.IdentityId,
                SessionToken = other.SessionToken,
                LoginTime = other.LoginTime,
                LogoutTime = other.LogoutTime,
                Name = other.Name,
                Email = other.Email,
                OptionalInfo = other.OptionalInfo,
                Roles = other.Roles.Select(r => Models.Account.AccessRole.Create(r)).ToArray(),
            };
        }
    }
}
#endif
//MdEnd
