using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Assignment1.Data
{
    public class UserService: IUserService
    {
        private List<User> users;

        public UserService()
        {
            users = new[]
            {
                new User
                {
                    UserName = "user",
                    Password = "admin",
                    Role = "Validated"
                },
                new User
                {
                    UserName = "Corona",
                    Password = "virus2021",
                    Role = "Validated"
                }
            }.ToList();
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User does not exist");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}