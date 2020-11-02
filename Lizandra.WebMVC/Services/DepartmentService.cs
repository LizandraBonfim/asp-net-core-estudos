using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lizandra.WebMVC.Data;
using Lizandra.WebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Lizandra.WebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(e => e.Name).ToListAsync();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}