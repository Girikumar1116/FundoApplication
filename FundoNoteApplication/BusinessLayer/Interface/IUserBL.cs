using CommonLayer.Models;
using Datalayer.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IUserBL
    {
        public UserEntity Register(UserRegistration user);
        public UserEntity Login(UserLogin login);
    }
}
