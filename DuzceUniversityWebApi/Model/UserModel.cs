using Microsoft.AspNetCore.Identity;

namespace DuzceUniversityWebApi.Model
{
    public class UserModel : IdentityUser
    {
        public UserModel(string userName) : base(userName)
        {
        }
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public string LastName { get; set; }
    }
}
