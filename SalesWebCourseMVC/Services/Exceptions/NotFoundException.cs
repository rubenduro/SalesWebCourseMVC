using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebCourseMVC.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }


    }
}
