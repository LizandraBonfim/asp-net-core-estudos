using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lizandra.WebMVC.Data;
using Lizandra.WebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Lizandra.WebMVC.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvcContext _context;

        public SalesRecordService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecords select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= minDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}