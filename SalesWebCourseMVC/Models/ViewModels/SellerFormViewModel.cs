using System;
using System.Linq;
using System.Collections.Generic;

namespace SalesWebCourseMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
