using Microsoft.AspNetCore.Identity; 

namespace BackOffice.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string? UserProfileId { get; set; }
        public virtual UserProfile? UserProfile { get; set; } // virtual for lazy loading

        public string? UserAddressId { get; set; }
        public virtual UserAddress? UserAddress { get; set; }
    }

}
