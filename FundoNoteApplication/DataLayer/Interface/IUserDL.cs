using CommonLayer.Models;
using Datalayer.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Interface
{
    public  interface IUserDL
    {
        public UserEntity Register(UserRegistration user);
        public UserEntity Login(UserLogin login);
    }
}
