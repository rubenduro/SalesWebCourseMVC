using SalesWebCourseMVC.Data;
using SalesWebCourseMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebCourseMVC.Services
{
    public class DepartmentService
    {
        private SalesWebCourseMVCContext _context;

        public DepartmentService(SalesWebCourseMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
