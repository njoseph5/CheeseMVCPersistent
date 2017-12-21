using CheeseMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class ViewMenuViewModel
    {
		public Menu Menu  { get; set; }
		public List<CheeseMenu> Items { get; set; }
		
	}
}
