using System.Collections.Generic;
using System.Linq;
using Lizandra.WebMVC.Data;
using Lizandra.WebMVC.Models;

namespace Lizandra.WebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(e => e.Name).ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}