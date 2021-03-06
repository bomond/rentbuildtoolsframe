﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace rentbuildtoolsframe.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Tool> Movies { get; set; }
		public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
		{
		}
		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
	}
}