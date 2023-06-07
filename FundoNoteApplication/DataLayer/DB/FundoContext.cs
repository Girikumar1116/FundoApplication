using System;
using System.Collections.Generic;
using System.Text;
using Datalayer.DB;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.DB
{
    //dbcontext bridge b/w db and application
    //tracks changes made to the entities and keeps a record of added, modified, and deleted entities
    public class FundoContext: DbContext  //entity mapping
    {
        public FundoContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<UserEntity> UserTable { get; set; } //entityset

        //through dbset create table and name of my table is Usertable
        //model is userentity
        //entity setprovide accsess to db tables and allow u 2 manipulate
    }
}
