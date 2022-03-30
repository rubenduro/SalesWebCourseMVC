using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebCourseMVC.Services.Exceptions
{
    public class DbConcurrencyException :ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {
        }
    }
}
