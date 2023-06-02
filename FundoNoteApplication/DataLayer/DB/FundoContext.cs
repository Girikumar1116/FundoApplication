using System;
using System.Collections.Generic;
using System.Text;
using Datalayer.DB;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.DB
{
    public class FundoContext: DbContext
    {
        public FundoContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<UserEntity> UserTable { get; set; }

        //through dbset create table and name of my table is Usertable
        //model is userentity
    }
}
