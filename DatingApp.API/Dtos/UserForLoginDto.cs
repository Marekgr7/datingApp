namespace DatingApp.API.Dtos
{
    public class UserForLoginDto
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public UserForLoginDto()
        {
            
        }

        public UserForLoginDto(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}