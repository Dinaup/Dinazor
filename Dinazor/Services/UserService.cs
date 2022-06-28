namespace BlazorApp2.Services
{
    public class UserService
    {
        public UserModel User;

        public EventHandler OnUserLoggedIn;

        public void LoginUser(LoginModel model)
        {
            if (model.Username == "xxx")
            {
                this.User = new UserModel();
                this.User.UserName = model.Username;
                this.User.SurName = "asd'";
                OnUserLoggedIn?.(this, null);
            }
        }
    }
}
