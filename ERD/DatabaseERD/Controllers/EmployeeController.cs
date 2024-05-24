using DatabaseERD.Data;
using DatabaseERD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace StoredProcedureTARge23.Controllers
{
    public class EmployeeController : Controller
    {
        public DatabaseERDDbContext _context;

        public EmployeeController
            (
            DatabaseERDDbContext context
            ) 
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IEnumerable<Employee> SearchResult()
        {
            var result = _context.Employees
                    .FromSqlRaw<Employee>("spSearchEmployees")
                    .ToList();

            return result;
        }
    }
}
