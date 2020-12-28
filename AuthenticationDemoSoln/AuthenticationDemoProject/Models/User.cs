using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticationDemoProject.Models
{
    public class User
    {
        [Required(ErrorMessage="Username can not be empty")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password can not be empty")]
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User()
        {
        }
    }
}