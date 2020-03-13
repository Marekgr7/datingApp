
namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        
        public string Username { get; set; }
        public string Password { get; set; }

		public UserForRegisterDto(){}
        public UserForRegisterDto(string username, string password)
        {
            this.Username = username;
            this.Password = password;

        }
    }
}