using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Datalayer.DB;
using DataLayer.Interface;
using CommonLayer.Models;
using DataLayer.DB;

namespace DataLayer.Services
{
    public class UserDL : IUserDL
    {
        private readonly FundoContext context;
        public UserDL(FundoContext context)
        {
            this.context = context;
        }
   // input sending match entity create a new record 
        public UserEntity Register(UserRegistration user)
        {
            try
            {
                UserEntity userentity = new UserEntity();
                userentity.FirstName = user.FirstName;
                userentity.LastName = user.LastName;
                userentity.PhoneNumber= user.PhoneNumber;
                userentity.Email = user.Email;
                userentity.Password = user.Password;
                
                userentity.RegisterAt = DateTime.Now;

                context.UserTable.Add(userentity);
                context.SaveChanges(); //save the changes

                if(userentity!=null)
                {
                    return userentity;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public UserEntity Login(UserLogin login)
        {
            try
            {
                UserEntity userentity = new UserEntity();
                userentity=context.UserTable.FirstOrDefault(x=>
                            x.Email==login.Email && x.Password==login.Password);
                if (userentity!=null)
                {
                    return userentity;
                }
                else { return null; }

            }
            catch (Exception) { throw; }
        }

    }
}
