using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Classes
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool TwoFactorEnabled { get; set; }

        public User(UserBuilder builder)
        {
            Name = builder.Name;
            Email = builder.Email;
            IsAdmin = builder.IsAdmin;
            TwoFactorEnabled = builder.TwoFactorEnabled;
        }
    }

    public class UserBuilder
    {
        public string Name { get; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool TwoFactorEnabled { get; set; }

        public UserBuilder(string Name)
        {
            this.Name = Name;
        }

        public UserBuilder SetEmail(string email)
        {
            this.Email = email;
            return this;
        }

        public UserBuilder SetAdmin(bool isAdmin)
        {
            IsAdmin = isAdmin;
            return this;
        }

        public UserBuilder SetTwoFactorAuth(bool TwoFactorEnabled)
        {
            this.TwoFactorEnabled = TwoFactorEnabled;
            return this;
        }

        public User Build()
        {
            return new User(this);
        }
    }
}
