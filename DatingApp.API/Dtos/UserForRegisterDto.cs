
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
		[Required]
		[StringLength(8, MinimumLength = 4, ErrorMessage = "Password should have between 4 and 8 characters")]
        public string Password { get; set; }

		public UserForRegisterDto(){}
        public UserForRegisterDto(string username, string password)
        {
            this.Username = username;
            this.Password = password;

        }
    }
}