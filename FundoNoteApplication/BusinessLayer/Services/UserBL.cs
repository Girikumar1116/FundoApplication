using BusinessLayer.Interface;
using CommonLayer.Models;
using Datalayer.DB;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public  class UserBL :IUserBL
    {
        private readonly IUserDL userDL;
        public UserBL(IUserDL userDL)
        {
            this.userDL = userDL;
            
        }
        public UserEntity Register(UserRegistration user)
        {
            try
            {
                return userDL.Register(user);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public UserEntity Login(UserLogin login) 
        {
            try
            {
                return userDL.Login(login);
            }
            catch (Exception) { throw; }
        }
    }
}
