﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
     public class Context :DbContext
    {


        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
