using rentbuildtoolsframe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace rentbuildtoolsframe.ViewModels
{
	public class RandomToolViewModel
	{
		public Tool Tool { get; set; }
		public List<Customer> Customers { get; set; }
	}
}