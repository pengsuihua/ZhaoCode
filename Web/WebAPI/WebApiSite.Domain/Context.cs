﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSite.Domain
{
    public class Context : DbContext
    {
        public Context() : base("name=WepApiConn")
        {

        }
        public DbSet<User> User { get; set; }
    }
}